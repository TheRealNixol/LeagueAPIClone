using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Trabalho.Models
{
    public class Champion
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public ChampionAbilities Abilities { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Lore { get; set; }

        [Required]
        public int Difficulty { get; set; }
    }
}
