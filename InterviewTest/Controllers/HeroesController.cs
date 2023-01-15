using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewTest.Controllers.Models;
using InterviewTest.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
    
        private readonly HeroesAPIDbContext dbContext;

        public HeroesController(HeroesAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        // GET: api/Heroes //gets all heroes 
        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            return dbContext.Heroes.ToList();
            //return this.heroes; 
        }

        // POST: api/Heroes //AddHero
        [HttpPost]
        public async Task<IActionResult> Post(AddHero addHero)
        {

            var hero = new Hero()
            {
                id = Guid.NewGuid(),
                name = addHero.name,
                power = addHero.power
            };

            await dbContext.Heroes.AddAsync(hero);
            await dbContext.SaveChangesAsync();


            

            return Ok(hero);
        }

        // PUT: api/Heroes/5
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Put([FromRoute] Guid id, EvolveHero evolveHero)
        {
            var hero = dbContext.Heroes.Find(id);

            if (hero != null)
            {
                hero.name = evolveHero.name;
                hero.power = evolveHero.power;

                await dbContext.SaveChangesAsync();

                return Ok(hero);
            }

             return NotFound();
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
