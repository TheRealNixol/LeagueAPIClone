using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Trabalho.Models
{
    public class UserQuickStat
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public Champion MainChamp { get; set; }
        public int HighestWinRateChamp { get; set; }
        public string RankSolo { get; set; }
        public string RankFlex { get; set; }
    }
}
