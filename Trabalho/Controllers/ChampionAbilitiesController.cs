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
    public class ChampionAbilitiesController : ControllerBase
    {
        private readonly DataContext _Db;

        public ChampionAbilitiesController(DataContext Db)
        {
            _Db = Db;
        }

        // GET: api/ChampionAbilities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionAbilities>>> GetChampionsAbilities()
        {
            return await _Db.ChampionsAbilities.ToListAsync();
        }

        // GET: api/ChampionAbilities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionAbilities>> GetChampionAbilities(int id)
        {
            var championAbilities = await _Db.ChampionsAbilities.FindAsync(id);

            if (championAbilities == null)
            {
                return NotFound();
            }

            return championAbilities;
        }

        // PUT: api/ChampionAbilities/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionAbilities(int id, ChampionAbilities championAbilities)
        {
            if (id != championAbilities.Id)
            {
                return BadRequest();
            }

            _Db.Entry(championAbilities).State = EntityState.Modified;

            try
            {
                await _Db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionAbilitiesExists(id))
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

        // POST: api/ChampionAbilities
        [HttpPost]
        public async Task<ActionResult<ChampionAbilities>> PostChampionAbilities(ChampionAbilities championAbilities)
        {
            _Db.ChampionsAbilities.Add(championAbilities);
            await _Db.SaveChangesAsync();
            //Quando criado retorna o objecto pela a database
            return CreatedAtAction("GetChampionAbilities", new { id = championAbilities.Id }, championAbilities);
        }

        // DELETE: api/ChampionAbilities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ChampionAbilities>> DeleteChampionAbilities(int id)
        {
            var championAbilities = await _Db.ChampionsAbilities.FindAsync(id);
            if (championAbilities == null)
            {
                return NotFound();
            }

            _Db.ChampionsAbilities.Remove(championAbilities);
            await _Db.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionAbilitiesExists(int id)
        {
            return _Db.ChampionsAbilities.Any(e => e.Id == id);
        }
    }
}
