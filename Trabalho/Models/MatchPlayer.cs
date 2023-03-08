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
        public IngameAccount User { get; set; }

        [Required]
        public Champion Champion { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        public float Gold { get; set; }

        public MatchBuild Build { get; set; }

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
