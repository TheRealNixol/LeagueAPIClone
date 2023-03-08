using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trabalho.Models;

namespace Trabalho.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {    
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserQuickStat> UsersQuickStat { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchTeam> MatchTeams { get; set; }
        public DbSet<MatchPlayer> MatchPlayers { get; set; }
        public DbSet<Champion> Champions { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ChampionAbilities> ChampionsAbilities { get; set; }
    }
}
