using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trabalho.Models;
using Trabalho.Data;
using Trabalho.CryptoLib;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Trabalho
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        
        private readonly DataContext Db;

        //the framework handles this
        public UsersController(DataContext _Db)
        {
            this.Db = _Db;
        }

        // GET: api/<controller>
        [HttpGet]
        public List<User> All()
        {
            using (this.Db)
            {
                //Podemos usar metodos LINQ para fazer queries mais especificar até como innerjoins.
                var Users = Db.Users.FromSqlRaw($"SELECT * FROM users").ToList();
                return Users;
            }
            //Utilizar funções async se restar tempo.. BTW i know that i need to work with tasks for the method to work, the problem consists on the DataContext Declaration itself

            /*using (var context = new DataContext())
            {
                return await context.Users.ToListAsync();
            }*/
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public List<User> Get(int id)
        {
            using (this.Db)
            {
                var User = Db.Users.FromSqlRaw($"SELECT * FROM users").Where(campo => campo.Id == id).ToList();
                return User;
            }
        }

        // POST api/<controller>
        [HttpPost]
        public bool Post([FromBody] User _User)
        {
            //Uma maneira mais orientada a objectos de inserir na DB via DataContext
            using (this.Db)
            {
                User NewUser = new User();
                // Campos a Inserir
                NewUser.Name = _User.Name;
                //Usa classe estática Encryptor para usar o metodo MD5Hash que ira encriptar a string
                NewUser.Password = Encryptor.MD5Hash(_User.Password);
                NewUser.Level = _User.Level;
                NewUser.Email = _User.Email;
                Db.Users.Add(NewUser);
                // Executa as modificações na BD. O método esta escrito em baixo e retorna bool dependendo se as modificações foram feitas ou não
                //return NewUser;
                return SaveChangesToDatabase();

            };
            
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody]User _User)
        {
            using (this.Db)
            {
                //Fetch o Row do user a modificar
                User TargetUser = Db.Users.Single(user => user.Id == id);
                //Declara que o User a modificar fica com as alterações enviadas
                TargetUser.Id = _User.Id;
                TargetUser.Name = _User.Name;
                //Usa classe estática Encryptor para usar o metodo MD5Hash que ira encriptar a string
                TargetUser.Password = Encryptor.MD5Hash(_User.Password);
                TargetUser.Level = _User.Level;
                TargetUser.Email = _User.Email;
                TargetUser.Token = _User.Token;
                // Executa as modificações na BD. O método esta escrito em baixo e retorna bool dependendo se as modificações foram feitas ou não
                return SaveChangesToDatabase();
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            using (this.Db)
            {
                //Fetch o Row do user a apagar
                User TargetUser = Db.Users.Single(user => user.Id == id);
                Db.Users.Remove(TargetUser);
                // Executa as modificações na BD. O método esta escrito em baixo e retorna bool dependendo se as modificações foram feitas ou não
                return SaveChangesToDatabase();
            }
        }

        private bool SaveChangesToDatabase()
        {
            // Executa as modificações na BD. A value da função passa a 1 se for escrito na BD
            if (Db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
