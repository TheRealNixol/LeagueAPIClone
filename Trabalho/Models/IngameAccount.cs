using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Trabalho.Models
{
    public class IngameAccount
    {
        [Required]
        public long Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        public IngameAccountQuickStat QuickStat { get; set; }
    }
}
