using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho.Models
{
    public class MatchTeam
    {
        public int Id { get; set; }
        public MatchPlayer User1 { get; set; }
        public MatchPlayer User2 { get; set; }
        public MatchPlayer User3 { get; set; }
        public MatchPlayer User4 { get; set; }
        public MatchPlayer User5 { get; set; }

        public float TotalGold { get; set; }
        public string Objectives { get; set; }
    }
}
