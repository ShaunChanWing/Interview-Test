using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private Hero[] heroes = new Hero[] {
               new Hero()
               {
                   name= "Hulk",
                   power="Strength from gamma radiation",
                   stats=
                   new List<KeyValuePair<string, int>>()
                   {
                       new KeyValuePair<string, int>( "strength", 5000 ),
                       new KeyValuePair<string, int>( "intelligence", 50),
                       new KeyValuePair<string, int>( "stamina", 2500 )
                   },
               },
               new Hero()
               {
                   name= "The Tick",
                   power="Incredible strength and drama power",
                   stats=
                   new List<KeyValuePair<string, int>>()
                   {
                       new KeyValuePair<string, int>( "strength", 600 ),
                       new KeyValuePair<string, int>( "intelligence", 5),
                       new KeyValuePair<string, int>( "stamina", 250 )
                   }
               },
               new Hero()
               {
                   name= "Iron Man",
                   power="Genius",
                   stats=
                   new List<KeyValuePair<string, int>>()
                   {
                       new KeyValuePair<string, int>( "strength", 50 ),
                       new KeyValuePair<string, int>( "intelligence", 10),
                       new KeyValuePair<string, int>( "stamina", 25 )
                   }
               },
               new Hero()
               {
                   name= "Batman",
                   power="Has Lots of Money",
                   stats=
                   new List<KeyValuePair<string, int>>()
                   {
                       new KeyValuePair<string, int>( "strength", 50 ),
                       new KeyValuePair<string, int>( "intelligence", 10),
                       new KeyValuePair<string, int>( "stamina", 25 )
                   }
               },
               new Hero()
               {
                   name= "Kick Ass",
                   power="Nerve Damage",
                   stats=
                   new List<KeyValuePair<string, int>>()
                   {
                       new KeyValuePair<string, int>( "strength", 50 ),
                       new KeyValuePair<string, int>( "intelligence", 10),
                       new KeyValuePair<string, int>( "stamina", 25 )
                   }
               }


            };

        //private Hero[] villains = new Hero[] {
        //       new Hero()
        //       {
        //           name= "Man Ray",
        //           power="Strength from gamma radiation",
        //           stats=
        //           new List<KeyValuePair<string, int>>()
        //           {
        //               new KeyValuePair<string, int>( "strength", 5000 ),
        //               new KeyValuePair<string, int>( "intelligence", 50),
        //               new KeyValuePair<string, int>( "stamina", 2500 )
        //           },
        //       }
  
        //    };



        // GET: api/Heroes //gets all heroes 
        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            return this.heroes;
            //return 
        }

        // GET: api/Heroes/5
        [HttpGet("{id}", Name = "Get")]
        public Hero Get(int id)
        {
            return this.heroes.FirstOrDefault();
        }

        // POST: api/Heroes //Evolve the hero
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {

            return Ok("hello from the other side");
        }

        // PUT: api/Heroes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
