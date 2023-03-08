using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Trabalho.Models
{
    public class MatchPlayer
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public Match Game { get; set; }

        [Required]
        public MatchTeam Team { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public Champion Champion { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        public int Gold { get; set; }

        [Required]
        public Item[] Build { get; set; }

        [Required]
        public int Kills { get; set; }

        [Required]
        public int Deaths { get; set; }

        [Required]
        public int Assists { get; set; }

        [Required]
        public float Kda { get; set; }
    }
}
