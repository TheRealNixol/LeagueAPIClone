using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho.Data;
using Trabalho.Models;

namespace Trabalho.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IngameAccountsController : ControllerBase
    {
        private readonly DataContext _Db;

        public IngameAccountsController(DataContext Db)
        {
            _Db = Db;
        }

        // GET: api/IngameAccounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IngameAccount>>> GetIngameAccounts()
        {
            return await _Db.IngameAccounts.Include(x => x.QuickStat).ThenInclude(xx => xx.MainChamp).ThenInclude(xxx => xxx.Abilities)
                                           .Include(y => y.QuickStat).ThenInclude(yy => yy.HighestWinRateChamp).ThenInclude(yyy => yyy.Abilities)
                                           .ToListAsync();
        }

        // GET: api/IngameAccounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IngameAccount>> GetIngameAccount(long id)
        {
            var ingameAccount = await _Db.IngameAccounts.Include(x => x.QuickStat).ThenInclude(xx => xx.MainChamp).ThenInclude(xxx => xxx.Abilities)
                                                        .Include(y => y.QuickStat).ThenInclude(yy => yy.HighestWinRateChamp).ThenInclude(yyy => yyy.Abilities)
                                                        .SingleAsync(acc => acc.Id == id);
            if (ingameAccount == null)
            {
                return NotFound();
            }

            return ingameAccount;
        }

        // PUT: api/IngameAccounts/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIngameAccount(long id, IngameAccount ingameAccount)
        {
            if (id != ingameAccount.Id)
            {
                return BadRequest();
            }
            IngameAccount AccountTarget = _Db.IngameAccounts.Single(acc => acc.Id == ingameAccount.Id);
            IngameAccountQuickStat QuickTarget = _Db.IngameAccountQuickStats.Single(q => q.Id == ingameAccount.QuickStat.Id);

            QuickTarget.MainChamp = ingameAccount.QuickStat.MainChamp;
            QuickTarget.HighestWinRateChamp = ingameAccount.QuickStat.HighestWinRateChamp;
            QuickTarget.RankFlex = ingameAccount.QuickStat.RankFlex;
            QuickTarget.RankSolo = ingameAccount.QuickStat.RankSolo;

            AccountTarget.Name = ingameAccount.Name;
            AccountTarget.Level = ingameAccount.Level;
            AccountTarget.QuickStat = QuickTarget;

            try
            {
                await _Db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngameAccountExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/IngameAccounts
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<IngameAccount>> PostIngameAccount(IngameAccount ingameAccount)
        {
            //Get Champ && Champ Abilities
            int MainChampId = ingameAccount.QuickStat.MainChamp.Id;
            ingameAccount.QuickStat.MainChamp = _Db.Champions.Include(x=> x.Abilities).SingleOrDefault(o => o.Id == MainChampId);

            int WinChampId = ingameAccount.QuickStat.HighestWinRateChamp.Id;
            ingameAccount.QuickStat.HighestWinRateChamp = _Db.Champions.Include(x => x.Abilities).SingleOrDefault(o => o.Id == WinChampId);


            _Db.IngameAccounts.Add(ingameAccount);
            await _Db.SaveChangesAsync();

            return CreatedAtAction("GetIngameAccount", new { id = ingameAccount.Id }, ingameAccount);
        }

        // DELETE: api/IngameAccounts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IngameAccount>> DeleteIngameAccount(long id)
        {
            var ingameAccount = await _Db.IngameAccounts.Include(qui => qui.QuickStat).SingleOrDefaultAsync(o => o.Id == id);
            if (ingameAccount == null)
            {
                return NotFound();
            }

            _Db.IngameAccountQuickStats.Remove(ingameAccount.QuickStat);
            _Db.IngameAccounts.Remove(ingameAccount);
            

            await _Db.SaveChangesAsync();

            return ingameAccount;
        }

        private bool IngameAccountExists(long id)
        {
            return _Db.IngameAccounts.Any(e => e.Id == id);
        }
    }
}
