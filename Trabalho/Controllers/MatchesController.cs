using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho.Data;
using Trabalho.Models;

namespace Trabalho.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        private readonly DataContext _context;

        public MatchesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Matches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Match>>> GetMatches()
        {                                 //Player 1
            List<Match> MatchListing = await _context.Matches.Include(y => y.TeamBlue).ThenInclude(yy => yy.User1).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User1).ThenInclude(yyy => yyy.User).ThenInclude(yyyy=> yyyy.QuickStat)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User1).ThenInclude(yyy => yyy.Build)
                                         //Player 2
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User2).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User2).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User2).ThenInclude(yyy => yyy.Build)
                                         //Player 3
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User3).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User3).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User3).ThenInclude(yyy => yyy.Build)
                                         //Player 4
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User4).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User4).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User4).ThenInclude(yyy => yyy.Build)
                                         //Player5
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User5).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User5).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User5).ThenInclude(yyy => yyy.Build)
                                         //RedTeam Player 1
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User1).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User1).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User1).ThenInclude(yyy => yyy.Build)
                                         //Player 2
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User2).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User2).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User2).ThenInclude(yyy => yyy.Build)
                                         //Player 3
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User3).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User3).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User3).ThenInclude(yyy => yyy.Build)
                                         //Player 4
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User4).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User4).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User4).ThenInclude(yyy => yyy.Build)
                                         //Player 5
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User5).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User5).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User5).ThenInclude(yyy => yyy.Build)
                                         .ToListAsync();

            foreach (Match MatchTarget in MatchListing) 
            {
                MatchTarget.TeamBlue.User1.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                                   .Include(y => y.Slot2)
                                                                   .Include(y => y.Slot3)
                                                                   .Include(y => y.Slot4)
                                                                   .Include(y => y.Slot5)
                                                                   .Include(y => y.Slot6)
                                                                   .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamBlue.User1.Build.Id);

                MatchTarget.TeamBlue.User2.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                                   .Include(y => y.Slot2)
                                                                   .Include(y => y.Slot3)
                                                                   .Include(y => y.Slot4)
                                                                   .Include(y => y.Slot5)
                                                                   .Include(y => y.Slot6)
                                                                   .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamBlue.User2.Build.Id);

                MatchTarget.TeamBlue.User3.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                                   .Include(y => y.Slot2)
                                                                   .Include(y => y.Slot3)
                                                                   .Include(y => y.Slot4)
                                                                   .Include(y => y.Slot5)
                                                                   .Include(y => y.Slot6)
                                                                   .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamBlue.User3.Build.Id);

                MatchTarget.TeamBlue.User4.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                                   .Include(y => y.Slot2)
                                                                   .Include(y => y.Slot3)
                                                                   .Include(y => y.Slot4)
                                                                   .Include(y => y.Slot5)
                                                                   .Include(y => y.Slot6)
                                                                   .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamBlue.User4.Build.Id);

                MatchTarget.TeamBlue.User5.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                                   .Include(y => y.Slot2)
                                                                   .Include(y => y.Slot3)
                                                                   .Include(y => y.Slot4)
                                                                   .Include(y => y.Slot5)
                                                                   .Include(y => y.Slot6)
                                                                   .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamBlue.User5.Build.Id);

                MatchTarget.TeamRed.User1.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                                   .Include(y => y.Slot2)
                                                                   .Include(y => y.Slot3)
                                                                   .Include(y => y.Slot4)
                                                                   .Include(y => y.Slot5)
                                                                   .Include(y => y.Slot6)
                                                                   .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamRed.User1.Build.Id);

                MatchTarget.TeamRed.User2.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                                   .Include(y => y.Slot2)
                                                                   .Include(y => y.Slot3)
                                                                   .Include(y => y.Slot4)
                                                                   .Include(y => y.Slot5)
                                                                   .Include(y => y.Slot6)
                                                                   .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamRed.User2.Build.Id);

                MatchTarget.TeamRed.User3.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                                   .Include(y => y.Slot2)
                                                                   .Include(y => y.Slot3)
                                                                   .Include(y => y.Slot4)
                                                                   .Include(y => y.Slot5)
                                                                   .Include(y => y.Slot6)
                                                                   .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamRed.User3.Build.Id);

                MatchTarget.TeamRed.User4.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                                   .Include(y => y.Slot2)
                                                                   .Include(y => y.Slot3)
                                                                   .Include(y => y.Slot4)
                                                                   .Include(y => y.Slot5)
                                                                   .Include(y => y.Slot6)
                                                                   .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamRed.User4.Build.Id);

                MatchTarget.TeamRed.User5.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                                   .Include(y => y.Slot2)
                                                                   .Include(y => y.Slot3)
                                                                   .Include(y => y.Slot4)
                                                                   .Include(y => y.Slot5)
                                                                   .Include(y => y.Slot6)
                                                                   .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamRed.User5.Build.Id);
            }
            return MatchListing;
        }

        // GET: api/Matches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Match>> GetMatch(int id)
        {
            var MatchTarget = await _context.Matches.Include(y => y.TeamBlue).ThenInclude(yy => yy.User1).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User1).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User1).ThenInclude(yyy => yyy.Build)
                                         //Player 2
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User2).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User2).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User2).ThenInclude(yyy => yyy.Build)
                                         //Player 3
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User3).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User3).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User3).ThenInclude(yyy => yyy.Build)
                                         //Player 4
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User4).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User4).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User4).ThenInclude(yyy => yyy.Build)
                                         //Player5
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User5).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User5).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamBlue).ThenInclude(yy => yy.User5).ThenInclude(yyy => yyy.Build)
                                         //RedTeam Player 1
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User1).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User1).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User1).ThenInclude(yyy => yyy.Build)
                                         //Player 2
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User2).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User2).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User2).ThenInclude(yyy => yyy.Build)
                                         //Player 3
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User3).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User3).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User3).ThenInclude(yyy => yyy.Build)
                                         //Player 4
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User4).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User4).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User4).ThenInclude(yyy => yyy.Build)
                                         //Player 5
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User5).ThenInclude(yyy => yyy.Champion)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User5).ThenInclude(yyy => yyy.User).ThenInclude(yyyy => yyyy.QuickStat)
                                         .Include(y => y.TeamRed).ThenInclude(yy => yy.User5).ThenInclude(yyy => yyy.Build)
                                         .SingleAsync(ma => ma.Id == id);

            if (MatchTarget == null)
            {
                return NotFound();
            }
            MatchTarget.TeamBlue.User1.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                                   .Include(y => y.Slot2)
                                                                   .Include(y => y.Slot3)
                                                                   .Include(y => y.Slot4)
                                                                   .Include(y => y.Slot5)
                                                                   .Include(y => y.Slot6)
                                                                   .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamBlue.User1.Build.Id);

            MatchTarget.TeamBlue.User2.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                               .Include(y => y.Slot2)
                                                               .Include(y => y.Slot3)
                                                               .Include(y => y.Slot4)
                                                               .Include(y => y.Slot5)
                                                               .Include(y => y.Slot6)
                                                               .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamBlue.User2.Build.Id);

            MatchTarget.TeamBlue.User3.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                               .Include(y => y.Slot2)
                                                               .Include(y => y.Slot3)
                                                               .Include(y => y.Slot4)
                                                               .Include(y => y.Slot5)
                                                               .Include(y => y.Slot6)
                                                               .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamBlue.User3.Build.Id);

            MatchTarget.TeamBlue.User4.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                               .Include(y => y.Slot2)
                                                               .Include(y => y.Slot3)
                                                               .Include(y => y.Slot4)
                                                               .Include(y => y.Slot5)
                                                               .Include(y => y.Slot6)
                                                               .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamBlue.User4.Build.Id);

            MatchTarget.TeamBlue.User5.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                               .Include(y => y.Slot2)
                                                               .Include(y => y.Slot3)
                                                               .Include(y => y.Slot4)
                                                               .Include(y => y.Slot5)
                                                               .Include(y => y.Slot6)
                                                               .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamBlue.User5.Build.Id);

            MatchTarget.TeamRed.User1.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                               .Include(y => y.Slot2)
                                                               .Include(y => y.Slot3)
                                                               .Include(y => y.Slot4)
                                                               .Include(y => y.Slot5)
                                                               .Include(y => y.Slot6)
                                                               .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamRed.User1.Build.Id);

            MatchTarget.TeamRed.User2.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                               .Include(y => y.Slot2)
                                                               .Include(y => y.Slot3)
                                                               .Include(y => y.Slot4)
                                                               .Include(y => y.Slot5)
                                                               .Include(y => y.Slot6)
                                                               .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamRed.User2.Build.Id);

            MatchTarget.TeamRed.User3.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                               .Include(y => y.Slot2)
                                                               .Include(y => y.Slot3)
                                                               .Include(y => y.Slot4)
                                                               .Include(y => y.Slot5)
                                                               .Include(y => y.Slot6)
                                                               .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamRed.User3.Build.Id);

            MatchTarget.TeamRed.User4.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                               .Include(y => y.Slot2)
                                                               .Include(y => y.Slot3)
                                                               .Include(y => y.Slot4)
                                                               .Include(y => y.Slot5)
                                                               .Include(y => y.Slot6)
                                                               .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamRed.User4.Build.Id);

            MatchTarget.TeamRed.User5.Build = await _context.MatchBuilds.Include(y => y.Slot1)
                                                               .Include(y => y.Slot2)
                                                               .Include(y => y.Slot3)
                                                               .Include(y => y.Slot4)
                                                               .Include(y => y.Slot5)
                                                               .Include(y => y.Slot6)
                                                               .Include(y => y.Trinket).SingleAsync(build => build.Id == MatchTarget.TeamRed.User5.Build.Id);

            return MatchTarget;
        }

        // PUT: api/Matches/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatch(int id, Match match)
        {
            if (id != match.Id)
            {
                return BadRequest();
            }

            Match MatchTarget = _context.Matches.Single(acc => acc.Id == match.Id);
            MatchTeam MatchTeamRedTarget = _context.MatchTeams.Single(ma => ma.Id == match.TeamRed.Id);
            MatchTeam MatchTeamBlueTarget = _context.MatchTeams.Single(ma => ma.Id == match.TeamBlue.Id);

            //------------------------------------------------TEAM RED -> USER 1------------------------------------------
            MatchPlayer TeamRedUser1 = _context.MatchPlayers.Single(pa => pa.Id == match.TeamRed.User1.Id);
            Champion TeamRedUser1Champ = _context.Champions.Single(champ => champ.Id == match.TeamRed.User1.Champion.Id);
            MatchBuild TeamRedUser1Build = _context.MatchBuilds.Single(build => build.Id == match.TeamRed.User1.Build.Id);

            TeamRedUser1Build = match.TeamRed.User1.Build;
            TeamRedUser1Champ = match.TeamRed.User1.Champion;
            TeamRedUser1 = match.TeamRed.User1;
            //------------------------------------------------TEAM RED -> USER 2------------------------------------------
            MatchPlayer TeamRedUser2 = _context.MatchPlayers.Single(pa => pa.Id == match.TeamRed.User2.Id);
            Champion TeamRedUser2Champ = _context.Champions.Single(champ => champ.Id == match.TeamRed.User2.Champion.Id);
            MatchBuild TeamRedUser2Build = _context.MatchBuilds.Single(build => build.Id == match.TeamRed.User2.Build.Id);

            TeamRedUser2Build = match.TeamRed.User2.Build;
            TeamRedUser2Champ = match.TeamRed.User2.Champion;
            TeamRedUser2 = match.TeamRed.User2;
            //------------------------------------------------TEAM RED -> USER 3------------------------------------------
            MatchPlayer TeamRedUser3 = _context.MatchPlayers.Single(pa => pa.Id == match.TeamRed.User3.Id);
            Champion TeamRedUser3Champ = _context.Champions.Single(champ => champ.Id == match.TeamRed.User3.Champion.Id);
            MatchBuild TeamRedUser3Build = _context.MatchBuilds.Single(build => build.Id == match.TeamRed.User3.Build.Id);

            TeamRedUser3Build = match.TeamRed.User3.Build;
            TeamRedUser3Champ = match.TeamRed.User3.Champion;
            TeamRedUser3 = match.TeamRed.User3;
            //------------------------------------------------TEAM RED -> USER 4------------------------------------------
            MatchPlayer TeamRedUser4 = _context.MatchPlayers.Single(pa => pa.Id == match.TeamRed.User4.Id);
            Champion TeamRedUser4Champ = _context.Champions.Single(champ => champ.Id == match.TeamRed.User4.Champion.Id);
            MatchBuild TeamRedUser4Build = _context.MatchBuilds.Single(build => build.Id == match.TeamRed.User4.Build.Id);

            TeamRedUser4Build = match.TeamRed.User4.Build;
            TeamRedUser4Champ = match.TeamRed.User4.Champion;
            TeamRedUser4 = match.TeamRed.User4;
            //------------------------------------------------TEAM RED -> USER 5------------------------------------------
            MatchPlayer TeamRedUser5 = _context.MatchPlayers.Single(pa => pa.Id == match.TeamRed.User5.Id);
            Champion TeamRedUser5Champ = _context.Champions.Single(champ => champ.Id == match.TeamRed.User5.Champion.Id);
            MatchBuild TeamRedUser5Build = _context.MatchBuilds.Single(build => build.Id == match.TeamRed.User5.Build.Id);

            TeamRedUser5Build = match.TeamRed.User5.Build;
            TeamRedUser5Champ = match.TeamRed.User5.Champion;
            TeamRedUser5 = match.TeamRed.User5;
            //------------------------------------------------TEAM BLUE -> USER 1------------------------------------------
            MatchPlayer TeamBlueUser1 = _context.MatchPlayers.Single(pa => pa.Id == match.TeamBlue.User1.Id);
            Champion TeamBlueUser1Champ = _context.Champions.Single(champ => champ.Id == match.TeamBlue.User1.Champion.Id);
            MatchBuild TeamBlueUser1Build = _context.MatchBuilds.Single(build => build.Id == match.TeamBlue.User1.Build.Id);

            TeamBlueUser1Build = match.TeamBlue.User1.Build;
            TeamBlueUser1Champ = match.TeamBlue.User1.Champion;
            TeamBlueUser1 = match.TeamBlue.User1;
            //------------------------------------------------TEAM BLUE -> USER 2------------------------------------------
            MatchPlayer TeamBlueUser2 = _context.MatchPlayers.Single(pa => pa.Id == match.TeamBlue.User2.Id);
            Champion TeamBlueUser2Champ = _context.Champions.Single(champ => champ.Id == match.TeamBlue.User2.Champion.Id);
            MatchBuild TeamBlueUser2Build = _context.MatchBuilds.Single(build => build.Id == match.TeamBlue.User2.Build.Id);

            TeamBlueUser2Build = match.TeamBlue.User2.Build;
            TeamBlueUser2Champ = match.TeamBlue.User2.Champion;
            TeamBlueUser2 = match.TeamBlue.User2;
            //------------------------------------------------TEAM BLUE -> USER 3------------------------------------------
            MatchPlayer TeamBlueUser3 = _context.MatchPlayers.Single(pa => pa.Id == match.TeamBlue.User3.Id);
            Champion TeamBlueUser3Champ = _context.Champions.Single(champ => champ.Id == match.TeamBlue.User3.Champion.Id);
            MatchBuild TeamBlueUser3Build = _context.MatchBuilds.Single(build => build.Id == match.TeamBlue.User3.Build.Id);

            TeamBlueUser3Build = match.TeamBlue.User3.Build;
            TeamBlueUser3Champ = match.TeamBlue.User3.Champion;
            TeamBlueUser3 = match.TeamBlue.User3;
            //------------------------------------------------TEAM BLUE -> USER 4------------------------------------------
            MatchPlayer TeamBlueUser4 = _context.MatchPlayers.Single(pa => pa.Id == match.TeamBlue.User4.Id);
            Champion TeamBlueUser4Champ = _context.Champions.Single(champ => champ.Id == match.TeamBlue.User4.Champion.Id);
            MatchBuild TeamBlueUser4Build = _context.MatchBuilds.Single(build => build.Id == match.TeamBlue.User4.Build.Id);

            TeamBlueUser4Build = match.TeamBlue.User4.Build;
            TeamBlueUser4Champ = match.TeamBlue.User4.Champion;
            TeamBlueUser4 = match.TeamBlue.User4;
            //------------------------------------------------TEAM BLUE -> USER 5------------------------------------------
            MatchPlayer TeamBlueUser5 = _context.MatchPlayers.Single(pa => pa.Id == match.TeamBlue.User5.Id);
            Champion TeamBlueUser5Champ = _context.Champions.Single(champ => champ.Id == match.TeamBlue.User5.Champion.Id);
            MatchBuild TeamBlueUser5Build = _context.MatchBuilds.Single(build => build.Id == match.TeamBlue.User5.Build.Id);

            TeamBlueUser5Build = match.TeamBlue.User5.Build;
            TeamBlueUser5Champ = match.TeamBlue.User5.Champion;
            TeamBlueUser5 = match.TeamBlue.User5;


            MatchTeamRedTarget = match.TeamRed;
            MatchTeamRedTarget = match.TeamBlue;

            MatchTarget = match;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatchExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private Item GetItem(Item slot) 
        {
            if (slot != null) 
            {
                slot = _context.Items.SingleOrDefault(z => z.Id == slot.Id);
                return slot;
            }

            return slot;
        }
        // POST: api/Matches
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Match>> PostMatch(Match match)
        {
            //TeamBlue
            //Get Players && Their Champion && Their Items: Para não reenscrever estas tabelas

            // ----------------------------------------------------------TEAM BLUE -> PLAYER 1 --------------------------------------------------------
            //Get IDS
            long TeamBlue_User1 = match.TeamBlue.User1.User.Id;
            int TeamBlue_User1_Champion = match.TeamBlue.User1.Champion.Id;

            //Fetch DATA WITH IDS
            //INGAMEACCOUNT && QUICKTATS
            match.TeamBlue.User1.User = _context.IngameAccounts.Include(x => x.QuickStat)
                                                          .ThenInclude(xx => xx.MainChamp)
                                                          .ThenInclude(xxx=> xxx.Abilities)
                                                          .Include(y => y.QuickStat)
                                                          .ThenInclude(yy => yy.MainChamp)
                                                          .ThenInclude(yyy => yyy.Abilities)
                                                          .SingleOrDefault(z => z.Id == TeamBlue_User1);
            //CHAMPION
            match.TeamBlue.User1.Champion = _context.Champions.Include(ab => ab.Abilities).SingleOrDefault(z => z.Id == TeamBlue_User1_Champion);
            //ITEMS
            match.TeamBlue.User1.Build.Slot1 = GetItem(match.TeamBlue.User1.Build.Slot1);
            match.TeamBlue.User1.Build.Slot2 = GetItem(match.TeamBlue.User1.Build.Slot2);
            match.TeamBlue.User1.Build.Slot3 = GetItem(match.TeamBlue.User1.Build.Slot3);
            match.TeamBlue.User1.Build.Slot4 = GetItem(match.TeamBlue.User1.Build.Slot4);
            match.TeamBlue.User1.Build.Slot5 = GetItem(match.TeamBlue.User1.Build.Slot5);
            match.TeamBlue.User1.Build.Slot6 = GetItem(match.TeamBlue.User1.Build.Slot6);
            match.TeamBlue.User1.Build.Trinket = GetItem(match.TeamBlue.User1.Build.Trinket);

            // ----------------------------------------------------------TEAM BLUE -> PLAYER 2 --------------------------------------------------------
            //Get IDS
            long TeamBlue_User2 = match.TeamBlue.User2.User.Id;
            int TeamBlue_User2_Champion = match.TeamBlue.User2.Champion.Id;

            //Fetch DATA WITH IDS
            //INGAMEACCOUNT && QUICKTATS
            match.TeamBlue.User2.User = _context.IngameAccounts.Include(x => x.QuickStat)
                                                          .ThenInclude(xx => xx.MainChamp)
                                                          .ThenInclude(xxx => xxx.Abilities)
                                                          .Include(y => y.QuickStat)
                                                          .ThenInclude(yy => yy.MainChamp)
                                                          .ThenInclude(yyy => yyy.Abilities)
                                                          .SingleOrDefault(z => z.Id == TeamBlue_User2);
            //CHAMPION
            match.TeamBlue.User2.Champion = _context.Champions.Include(ab => ab.Abilities).SingleOrDefault(z => z.Id == TeamBlue_User2_Champion);
            //ITEMS
            match.TeamBlue.User2.Build.Slot1 = GetItem(match.TeamBlue.User2.Build.Slot1);
            match.TeamBlue.User2.Build.Slot2 = GetItem(match.TeamBlue.User2.Build.Slot2);
            match.TeamBlue.User2.Build.Slot3 = GetItem(match.TeamBlue.User2.Build.Slot3);
            match.TeamBlue.User2.Build.Slot4 = GetItem(match.TeamBlue.User2.Build.Slot4);
            match.TeamBlue.User2.Build.Slot5 = GetItem(match.TeamBlue.User2.Build.Slot5);
            match.TeamBlue.User2.Build.Slot6 = GetItem(match.TeamBlue.User2.Build.Slot6);
            match.TeamBlue.User2.Build.Trinket = GetItem(match.TeamBlue.User2.Build.Trinket);

            // ----------------------------------------------------------TEAM BLUE -> PLAYER 3 --------------------------------------------------------
            //Get IDS
            long TeamBlue_User3 = match.TeamBlue.User3.User.Id;
            int TeamBlue_User3_Champion = match.TeamBlue.User3.Champion.Id;

            //Fetch DATA WITH IDS
            //INGAMEACCOUNT && QUICKTATS
            match.TeamBlue.User3.User = _context.IngameAccounts.Include(x => x.QuickStat)
                                                          .ThenInclude(xx => xx.MainChamp)
                                                          .ThenInclude(xxx => xxx.Abilities)
                                                          .Include(y => y.QuickStat)
                                                          .ThenInclude(yy => yy.MainChamp)
                                                          .ThenInclude(yyy => yyy.Abilities)
                                                          .SingleOrDefault(z => z.Id == TeamBlue_User3);
            //CHAMPION
            match.TeamBlue.User3.Champion = _context.Champions.Include(ab => ab.Abilities).SingleOrDefault(z => z.Id == TeamBlue_User3_Champion);
            //ITEMS
            match.TeamBlue.User3.Build.Slot1 = GetItem(match.TeamBlue.User3.Build.Slot1);
            match.TeamBlue.User3.Build.Slot2 = GetItem(match.TeamBlue.User3.Build.Slot2);
            match.TeamBlue.User3.Build.Slot3 = GetItem(match.TeamBlue.User3.Build.Slot3);
            match.TeamBlue.User3.Build.Slot4 = GetItem(match.TeamBlue.User3.Build.Slot4);
            match.TeamBlue.User3.Build.Slot5 = GetItem(match.TeamBlue.User3.Build.Slot5);
            match.TeamBlue.User3.Build.Slot6 = GetItem(match.TeamBlue.User3.Build.Slot6);
            match.TeamBlue.User3.Build.Trinket = GetItem(match.TeamBlue.User3.Build.Trinket);

            // ----------------------------------------------------------TEAM BLUE -> PLAYER 4 --------------------------------------------------------
            //Get IDS

            long TeamBlue_User4 = match.TeamBlue.User4.User.Id;
            int TeamBlue_User4_Champion = match.TeamBlue.User4.Champion.Id;

            //Fetch DATA WITH IDS
            //INGAMEACCOUNT && QUICKTATS
            match.TeamBlue.User4.User = _context.IngameAccounts.Include(x => x.QuickStat)
                                                          .ThenInclude(xx => xx.MainChamp)
                                                          .ThenInclude(xxx => xxx.Abilities)
                                                          .Include(y => y.QuickStat)
                                                          .ThenInclude(yy => yy.MainChamp)
                                                          .ThenInclude(yyy => yyy.Abilities)
                                                          .SingleOrDefault(z => z.Id == TeamBlue_User4);
            //CHAMPION
            match.TeamBlue.User4.Champion = _context.Champions.Include(ab => ab.Abilities).SingleOrDefault(z => z.Id == TeamBlue_User4_Champion);
            //ITEMS
            match.TeamBlue.User4.Build.Slot1 = GetItem(match.TeamBlue.User4.Build.Slot1);
            match.TeamBlue.User4.Build.Slot2 = GetItem(match.TeamBlue.User4.Build.Slot2);
            match.TeamBlue.User4.Build.Slot3 = GetItem(match.TeamBlue.User4.Build.Slot3);
            match.TeamBlue.User4.Build.Slot4 = GetItem(match.TeamBlue.User4.Build.Slot4);
            match.TeamBlue.User4.Build.Slot5 = GetItem(match.TeamBlue.User4.Build.Slot5);
            match.TeamBlue.User4.Build.Slot6 = GetItem(match.TeamBlue.User4.Build.Slot6);
            match.TeamBlue.User4.Build.Trinket = GetItem(match.TeamBlue.User4.Build.Trinket);

            // ----------------------------------------------------------TEAM BLUE -> PLAYER 5 --------------------------------------------------------
            //Get IDS

            long TeamBlue_User5 = match.TeamBlue.User5.User.Id;
            int TeamBlue_User5_Champion = match.TeamBlue.User5.Champion.Id;
         
            //Fetch DATA WITH IDS
            //INGAMEACCOUNT && QUICKTATS
            match.TeamBlue.User5.User = _context.IngameAccounts.Include(x => x.QuickStat)
                                                          .ThenInclude(xx => xx.MainChamp)
                                                          .ThenInclude(xxx => xxx.Abilities)
                                                          .Include(y => y.QuickStat)
                                                          .ThenInclude(yy => yy.MainChamp)
                                                          .ThenInclude(yyy => yyy.Abilities)
                                                          .SingleOrDefault(z => z.Id == TeamBlue_User5);
            //CHAMPION
            match.TeamBlue.User5.Champion = _context.Champions.Include(ab => ab.Abilities).SingleOrDefault(z => z.Id == TeamBlue_User5_Champion);
            //ITEMS
            match.TeamBlue.User5.Build.Slot1 = GetItem(match.TeamBlue.User5.Build.Slot1);
            match.TeamBlue.User5.Build.Slot2 = GetItem(match.TeamBlue.User5.Build.Slot2);
            match.TeamBlue.User5.Build.Slot3 = GetItem(match.TeamBlue.User5.Build.Slot3);
            match.TeamBlue.User5.Build.Slot4 = GetItem(match.TeamBlue.User5.Build.Slot4);
            match.TeamBlue.User5.Build.Slot5 = GetItem(match.TeamBlue.User5.Build.Slot5);
            match.TeamBlue.User5.Build.Slot6 = GetItem(match.TeamBlue.User5.Build.Slot6);
            match.TeamBlue.User5.Build.Trinket = GetItem(match.TeamBlue.User5.Build.Trinket);


            //TeamRed
            //Get Players
            // ----------------------------------------------------------TEAM RED -> PLAYER 1 --------------------------------------------------------
            //Get IDS
            long TeamRed_User1 = match.TeamRed.User1.User.Id;
            int TeamRed_User1_Champion = match.TeamRed.User1.Champion.Id;

            //Fetch DATA WITH IDS
            //INGAMEACCOUNT && QUICKTATS
            match.TeamRed.User1.User = _context.IngameAccounts.Include(x => x.QuickStat)
                                                          .ThenInclude(xx => xx.MainChamp)
                                                          .ThenInclude(xxx => xxx.Abilities)
                                                          .Include(y => y.QuickStat)
                                                          .ThenInclude(yy => yy.MainChamp)
                                                          .ThenInclude(yyy => yyy.Abilities)
                                                          .SingleOrDefault(z => z.Id == TeamRed_User1);

            //CHAMPION
            match.TeamRed.User1.Champion = _context.Champions.Include(ab => ab.Abilities).SingleOrDefault(z => z.Id == TeamRed_User1_Champion);
            //ITEMS
            match.TeamRed.User1.Build.Slot1 = GetItem(match.TeamRed.User1.Build.Slot1);
            match.TeamRed.User1.Build.Slot2 = GetItem(match.TeamRed.User1.Build.Slot2);
            match.TeamRed.User1.Build.Slot3 = GetItem(match.TeamRed.User1.Build.Slot3);
            match.TeamRed.User1.Build.Slot4 = GetItem(match.TeamRed.User1.Build.Slot4);
            match.TeamRed.User1.Build.Slot5 = GetItem(match.TeamRed.User1.Build.Slot5);
            match.TeamRed.User1.Build.Slot6 = GetItem(match.TeamRed.User1.Build.Slot6);
            match.TeamRed.User1.Build.Trinket = GetItem(match.TeamRed.User1.Build.Trinket);

            // ----------------------------------------------------------TEAM RED -> PLAYER 2 --------------------------------------------------------
            //Get IDS
            long TeamRed_User2 = match.TeamRed.User2.User.Id;
            int TeamRed_User2_Champion = match.TeamRed.User2.Champion.Id;

            //Fetch DATA WITH IDS
            //INGAMEACCOUNT && QUICKTATS
            match.TeamRed.User2.User = _context.IngameAccounts.Include(x => x.QuickStat)
                                                          .ThenInclude(xx => xx.MainChamp)
                                                          .ThenInclude(xxx => xxx.Abilities)
                                                          .Include(y => y.QuickStat)
                                                          .ThenInclude(yy => yy.MainChamp)
                                                          .ThenInclude(yyy => yyy.Abilities)
                                                          .SingleOrDefault(z => z.Id == TeamRed_User2);
            //CHAMPION
            match.TeamRed.User2.Champion = _context.Champions.Include(ab => ab.Abilities).SingleOrDefault(z => z.Id == TeamRed_User2_Champion);
            //ITEMS
            match.TeamRed.User2.Build.Slot1 = GetItem(match.TeamRed.User2.Build.Slot1);
            match.TeamRed.User2.Build.Slot2 = GetItem(match.TeamRed.User2.Build.Slot2);
            match.TeamRed.User2.Build.Slot3 = GetItem(match.TeamRed.User2.Build.Slot3);
            match.TeamRed.User2.Build.Slot4 = GetItem(match.TeamRed.User2.Build.Slot4);
            match.TeamRed.User2.Build.Slot5 = GetItem(match.TeamRed.User2.Build.Slot5);
            match.TeamRed.User2.Build.Slot6 = GetItem(match.TeamRed.User2.Build.Slot6);
            match.TeamRed.User2.Build.Trinket = GetItem(match.TeamRed.User2.Build.Trinket);

            // ----------------------------------------------------------TEAM RED -> PLAYER 3 --------------------------------------------------------
            //Get IDS
            long TeamRed_User3 = match.TeamRed.User3.User.Id;
            int TeamRed_User3_Champion = match.TeamRed.User3.Champion.Id;
            //Fetch DATA WITH IDS
            //INGAMEACCOUNT && QUICKTATS
            match.TeamRed.User3.User = _context.IngameAccounts.Include(x => x.QuickStat)
                                                          .ThenInclude(xx => xx.MainChamp)
                                                          .ThenInclude(xxx => xxx.Abilities)
                                                          .Include(y => y.QuickStat)
                                                          .ThenInclude(yy => yy.MainChamp)
                                                          .ThenInclude(yyy => yyy.Abilities)
                                                          .SingleOrDefault(z => z.Id == TeamRed_User3);
            //CHAMPION
            match.TeamRed.User3.Champion = _context.Champions.Include(ab => ab.Abilities).SingleOrDefault(z => z.Id == TeamRed_User3_Champion);
            //ITEMS
            match.TeamRed.User3.Build.Slot1 = GetItem(match.TeamRed.User3.Build.Slot1);
            match.TeamRed.User3.Build.Slot2 = GetItem(match.TeamRed.User3.Build.Slot2);
            match.TeamRed.User3.Build.Slot3 = GetItem(match.TeamRed.User3.Build.Slot3);
            match.TeamRed.User3.Build.Slot4 = GetItem(match.TeamRed.User3.Build.Slot4);
            match.TeamRed.User3.Build.Slot5 = GetItem(match.TeamRed.User3.Build.Slot5);
            match.TeamRed.User3.Build.Slot6 = GetItem(match.TeamRed.User3.Build.Slot6);
            match.TeamRed.User3.Build.Trinket = GetItem(match.TeamRed.User3.Build.Trinket);

            // ----------------------------------------------------------TEAM RED -> PLAYER 4 --------------------------------------------------------
            //Get IDS
            long TeamRed_User4 = match.TeamRed.User4.User.Id;
            int TeamRed_User4_Champion = match.TeamRed.User4.Champion.Id;

            //Fetch DATA WITH IDS
            //INGAMEACCOUNT && QUICKTATS
            match.TeamRed.User4.User = _context.IngameAccounts.Include(x => x.QuickStat)
                                                          .ThenInclude(xx => xx.MainChamp)
                                                          .ThenInclude(xxx => xxx.Abilities)
                                                          .Include(y => y.QuickStat)
                                                          .ThenInclude(yy => yy.MainChamp)
                                                          .ThenInclude(yyy => yyy.Abilities)
                                                          .SingleOrDefault(z => z.Id == TeamRed_User4);
            //CHAMPION
            match.TeamRed.User4.Champion = _context.Champions.Include(ab => ab.Abilities).SingleOrDefault(z => z.Id == TeamRed_User4_Champion);
            //ITEMS
            match.TeamRed.User4.Build.Slot1 = GetItem(match.TeamRed.User4.Build.Slot1);
            match.TeamRed.User4.Build.Slot2 = GetItem(match.TeamRed.User4.Build.Slot2);
            match.TeamRed.User4.Build.Slot3 = GetItem(match.TeamRed.User4.Build.Slot3);
            match.TeamRed.User4.Build.Slot4 = GetItem(match.TeamRed.User4.Build.Slot4);
            match.TeamRed.User4.Build.Slot5 = GetItem(match.TeamRed.User4.Build.Slot5);
            match.TeamRed.User4.Build.Slot6 = GetItem(match.TeamRed.User4.Build.Slot6);
            match.TeamRed.User4.Build.Trinket = GetItem(match.TeamRed.User4.Build.Trinket);

            // ----------------------------------------------------------TEAM RED -> PLAYER 5 --------------------------------------------------------
            //Get IDS
            long TeamRed_User5 = match.TeamRed.User5.User.Id;
            int TeamRed_User5_Champion = match.TeamRed.User5.Champion.Id;
          
            //Fetch DATA WITH IDS
            //INGAMEACCOUNT && QUICKTATS
            match.TeamRed.User5.User = _context.IngameAccounts.Include(x => x.QuickStat)
                                                          .ThenInclude(xx => xx.MainChamp)
                                                          .ThenInclude(xxx => xxx.Abilities)
                                                          .Include(y => y.QuickStat)
                                                          .ThenInclude(yy => yy.MainChamp)
                                                          .ThenInclude(yyy => yyy.Abilities)
                                                          .SingleOrDefault(z => z.Id == TeamRed_User5);
            //CHAMPION
            match.TeamRed.User5.Champion = _context.Champions.Include(ab => ab.Abilities).SingleOrDefault(z => z.Id == TeamRed_User5_Champion);
            //ITEMS
            match.TeamRed.User5.Build.Slot1 = GetItem(match.TeamRed.User5.Build.Slot1);
            match.TeamRed.User5.Build.Slot2 = GetItem(match.TeamRed.User5.Build.Slot2);
            match.TeamRed.User5.Build.Slot3 = GetItem(match.TeamRed.User5.Build.Slot3);
            match.TeamRed.User5.Build.Slot4 = GetItem(match.TeamRed.User5.Build.Slot4);
            match.TeamRed.User5.Build.Slot5 = GetItem(match.TeamRed.User5.Build.Slot5);
            match.TeamRed.User5.Build.Slot6 = GetItem(match.TeamRed.User5.Build.Slot6);
            match.TeamRed.User5.Build.Trinket = GetItem(match.TeamRed.User5.Build.Trinket);

            //WRITE MATCH IN DATABASE
            _context.Matches.Add(match);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMatch", new { id = match.Id }, match);
        }

        // DELETE: api/Matches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Match>> DeleteMatch(int id)
        {
            var match = await _context.Matches.Include(y => y.TeamBlue).ThenInclude(yy => yy.User1).ThenInclude(yyy => yyy.Build)
                                              .Include(y => y.TeamBlue).ThenInclude(yy => yy.User2).ThenInclude(yyy => yyy.Build)
                                              .Include(y => y.TeamBlue).ThenInclude(yy => yy.User3).ThenInclude(yyy => yyy.Build)
                                              .Include(y => y.TeamBlue).ThenInclude(yy => yy.User4).ThenInclude(yyy => yyy.Build)
                                              .Include(y => y.TeamBlue).ThenInclude(yy => yy.User5).ThenInclude(yyy => yyy.Build)
                                              .Include(y => y.TeamRed).ThenInclude(yy => yy.User1).ThenInclude(yyy => yyy.Build)
                                              .Include(y => y.TeamRed).ThenInclude(yy => yy.User2).ThenInclude(yyy => yyy.Build)
                                              .Include(y => y.TeamRed).ThenInclude(yy => yy.User3).ThenInclude(yyy => yyy.Build)
                                              .Include(y => y.TeamRed).ThenInclude(yy => yy.User4).ThenInclude(yyy => yyy.Build)
                                              .Include(y => y.TeamRed).ThenInclude(yy => yy.User5).ThenInclude(yyy => yyy.Build)
                                              .SingleOrDefaultAsync(o => o.Id == id);
            if (match == null)
            {
                return NotFound();
            }

            //builds primeiro
            _context.MatchBuilds.Remove(match.TeamBlue.User1.Build);
            _context.MatchBuilds.Remove(match.TeamBlue.User2.Build);
            _context.MatchBuilds.Remove(match.TeamBlue.User3.Build);
            _context.MatchBuilds.Remove(match.TeamBlue.User4.Build);
            _context.MatchBuilds.Remove(match.TeamBlue.User5.Build);
            _context.MatchBuilds.Remove(match.TeamRed.User1.Build);
            _context.MatchBuilds.Remove(match.TeamRed.User2.Build);
            _context.MatchBuilds.Remove(match.TeamRed.User3.Build);
            _context.MatchBuilds.Remove(match.TeamRed.User4.Build);
            _context.MatchBuilds.Remove(match.TeamRed.User5.Build);
            // Match players aseguir
            _context.MatchPlayers.Remove(match.TeamBlue.User1);
            _context.MatchPlayers.Remove(match.TeamBlue.User2);
            _context.MatchPlayers.Remove(match.TeamBlue.User3);
            _context.MatchPlayers.Remove(match.TeamBlue.User4);
            _context.MatchPlayers.Remove(match.TeamBlue.User5);
            _context.MatchPlayers.Remove(match.TeamRed.User1);
            _context.MatchPlayers.Remove(match.TeamRed.User2);
            _context.MatchPlayers.Remove(match.TeamRed.User3);
            _context.MatchPlayers.Remove(match.TeamRed.User4);
            _context.MatchPlayers.Remove(match.TeamRed.User5);

            //Match Team aseguir
            _context.MatchTeams.Remove(match.TeamRed);
            _context.MatchTeams.Remove(match.TeamBlue);

            //Por fim Match
            _context.Matches.Remove(match);

            _context.Matches.Remove(match);
            await _context.SaveChangesAsync();

            return match;
        }

        private bool MatchExists(int id)
        {
            return _context.Matches.Any(e => e.Id == id);
        }
    }
}
