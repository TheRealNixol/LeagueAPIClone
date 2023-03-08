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

        [StringLength(50)]
        public string Email { get; set; }

        public IngameAccount Account { get; set; }

        public string Token { get; set; }
    }
}
