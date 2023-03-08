using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trabalho.Models;
using Trabalho.Data;
using Trabalho.CryptoLib;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Trabalho.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Trabalho
{
    
    [ApiController]
    [Route("[controller]")]
    //NAO ESQUECER DE PASSAR OS METODOS DE USERCONTROLLER PARA ASYNC
    public class UsersController : ControllerBase
    {
        
        private readonly DataContext _Db;
        private IUserService _userService;

        public UsersController(IUserService userService, DataContext Db)
        {
            _userService = userService;
            this._Db = Db;
        }

        //Authentication Request 
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]User userParam)
        {
            var user = await _userService.Authenticate(userParam.Name, Encryptor.MD5Hash(userParam.Password));

            if (user == null)
                return BadRequest(new { message = "Username or Password is incorrect" });

            return Ok(true);
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> All()
        {
            return await _Db.Users.Include(x=> x.Account)
                                  .ThenInclude(xx => xx.QuickStat)
                                  .ThenInclude(xxx => xxx.MainChamp)
                                  .ThenInclude(xxxx => xxxx.Abilities)
                                  .Include(y => y.Account)
                                  .ThenInclude(yy => yy.QuickStat)
                                  .ThenInclude(yyy => yyy.HighestWinRateChamp)
                                  .ThenInclude(yyyy => yyyy.Abilities)
                                  .ToListAsync();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var user = await _Db.Users.Include(x => x.Account)
                                  .ThenInclude(xx => xx.QuickStat)
                                  .ThenInclude(xxx => xxx.MainChamp)
                                  .ThenInclude(xxxx => xxxx.Abilities)
                                  .Include(y => y.Account)
                                  .ThenInclude(yy => yy.QuickStat)
                                  .ThenInclude(yyy => yyy.HighestWinRateChamp)
                                  .ThenInclude(yyyy => yyyy.Abilities)
                                  .SingleAsync(_user => _user.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] User _User)
        {
            long AccountId = _User.Account.Id;
            _User.Account = _Db.IngameAccounts.SingleOrDefault(o => o.Id == AccountId);
            //Hash the password
            _User.Password = Encryptor.MD5Hash(_User.Password);


            _Db.Users.Add(_User);
            await _Db.SaveChangesAsync();
            return CreatedAtAction("Get", new { id = _User.Id }, _User);

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> Put(int id, [FromBody]User _User)
        {
            if (id != _User.Id)
            {
                return BadRequest();
            }
            // Get Account Entity to be able to put into User Update 
            long AccountId = _User.Account.Id;
            _User.Account = _Db.IngameAccounts.SingleOrDefault(o => o.Id == AccountId);

            //Get User Entity
            User UserTarget = _Db.Users.Single(x => x.Id == id);

            UserTarget.Name = _User.Name;
            UserTarget.Password = _User.Password;
            UserTarget.Email = _User.Email;
            UserTarget.Token = _User.Token;
            //User Account goes Unchanged
            UserTarget.Account = _User.Account;

            try
            {
                await _Db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return CreatedAtAction("Get", new { id = _User.Id }, _User);


        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var UserTarget = await _Db.Users.FindAsync(id);
            if (UserTarget == null)
            {
                return NotFound();
            }

            _Db.Users.Remove(UserTarget);
            await _Db.SaveChangesAsync();

            return true;
        }

        private bool UserExists(int id)
        {
            return _Db.Users.Any(e => e.Id == id);
        }
    }
}
