using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho.Data;
using Trabalho.Models;

namespace Trabalho.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ChampionsController : ControllerBase
    {
        private readonly DataContext _Db;

        public ChampionsController(DataContext Db)
        {
            _Db = Db;
        }

        // GET: api/Champions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Champion>>> GetChampions()
        {
            return await _Db.Champions.Include(x => x.Abilities).ToListAsync();
        }

        // GET: api/Champions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Champion>> GetChampion(int id)
        {
            var champion = await _Db.Champions.Include(x => x.Abilities).SingleAsync(champ => champ.Id == id);

            if (champion == null)
            {
                return NotFound();
            }

            return champion;
        }

        // PUT: api/Champions/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Champion>> PutChampion(int id, Champion champion)
        {
            if (id != champion.Id)
            {
                return BadRequest();
            }

            // (------)Update Both Champion&ChampionAbilities(------)

            //Get Both Entities respective row in DB
            Champion ChampionTarget = _Db.Champions.Single(champ => champ.Id == id);
            ChampionAbilities ChampionAbilitiesTarget = _Db.ChampionsAbilities.Single(champ_abs=> champ_abs.Id == champion.Abilities.Id);

            //ChampionAbilities First
            ChampionAbilitiesTarget.Passive = champion.Abilities.Passive;
            ChampionAbilitiesTarget.Q = champion.Abilities.Q;
            ChampionAbilitiesTarget.W = champion.Abilities.W;
            ChampionAbilitiesTarget.E = champion.Abilities.E;
            ChampionAbilitiesTarget.R = champion.Abilities.R;

            //Champion second 
            ChampionTarget.Id = champion.Id;
            ChampionTarget.Abilities = ChampionAbilitiesTarget;
            ChampionTarget.Name = champion.Name;
            ChampionTarget.Lore = champion.Lore;
            ChampionTarget.Difficulty = champion.Difficulty;
            
            try
            {
                await _Db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return CreatedAtAction("GetChampion", new { id = champion.Id }, champion);
        }

        // POST: api/Champions
        [HttpPost]
        public async Task<ActionResult<Champion>> PostChampion(Champion champion)
        {

            int AbilitiesId = champion.Abilities.Id;
            champion.Abilities = _Db.ChampionsAbilities.SingleOrDefault(o => o.Id == AbilitiesId);
            
            _Db.Champions.Add(champion);
            await _Db.SaveChangesAsync();
            return CreatedAtAction("GetChampion", new { id = champion.Id }, champion);
            
        }

        // DELETE: api/Champions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Champion>> DeleteChampion(int id)
        {
            var champion = await _Db.Champions.FindAsync(id);
            if (champion == null)
            {
                return NotFound();
            }

            _Db.Champions.Remove(champion);
            await _Db.SaveChangesAsync();

            return champion;
        }

        private bool ChampionExists(int id)
        {
            return _Db.Champions.Any(e => e.Id == id);
        }
    }
}
