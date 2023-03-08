using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho.Models
{
    public class MatchTeam
    {
        public int Id { get; set; }
        public User User1 { get; set; }
        public User User2 { get; set; }
        public User User3 { get; set; }
        public User User4 { get; set; }
        public User User5 { get; set; }

        public int TotalGold { get; set; }
        public string Objectives { get; set; }
    }
}
