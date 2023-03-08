using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Trabalho.Models
{
    public class User
    {
        [Required]
        public long Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(60)]
        public string Password { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        public string Token { get; set; }

        
        /*public User(long _Id, string _Name, string _Password, int _Level, string _Email, string _Token) 
        {
            this.Id = _Id;
            this.Name = _Name;
            this.Password = _Password;
            this.Level = _Level;
            this.Email = _Email;
            this.Token = _Token;
        }*/
    }
}
