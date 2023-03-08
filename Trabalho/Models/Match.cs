using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Trabalho.Models
{
    public class Match
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public MatchTeam TeamBlue { get; set; }

        [Required]
        public MatchTeam TeamRed { get; set; }

        [Required]
        public string GameType { get; set; }

        [Required]
        public string Time { get; set; }

        [Required]
        public MatchTeam Winner { get; set; }
    }
}
