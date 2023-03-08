using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Trabalho.Models
{
    public class IngameAccountQuickStat
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public Champion MainChamp { get; set; }
        [Required]
        public Champion HighestWinRateChamp { get; set; }
        public string RankSolo { get; set; }
        public string RankFlex { get; set; }
    }
}
