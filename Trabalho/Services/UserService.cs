using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Trabalho.Models;
using Trabalho.Helpers;
using Trabalho.Data;
using Microsoft.EntityFrameworkCore;

namespace Trabalho.Services
{
    
    public interface IUserService
    {
        
        
        Task<User> Authenticate(string username, string password);
        Task<IEnumerable<User>> GetAll();
    }

    public class UserService : IUserService
    {
        private readonly DataContext Db;
        public UserService(DataContext _Db)
        {
            this.Db = _Db;
        }
        private List<User> GetUsers()
        {
            using (this.Db)
            {
                var Users = Db.Users.FromSqlRaw($"SELECT * FROM users").ToList();
                return Users;
            }
        }

        public async Task<User> Authenticate(string username, string password)
        {
            var user = await Task.Run(() => GetUsers().SingleOrDefault(x => x.Name == username && x.Password == password));

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so return user details without password
            user.Password = null;
            return user;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            // return users without passwords
            return await Task.Run(() => GetUsers().Select(x => {
                x.Password = null;
                return x;
            }));
        }
    }
}
