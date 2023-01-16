using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTest.Controllers
{
    public class Hero : IHero
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string power { get; set; }

        public int strength { get; set; }
        public int intelligence { get; set; }
        public int stamina { get; set; }

        //public List<KeyValuePair<string, int>> stats { get; set; }

        //public List<HeroStats> stats { get; set; }
        public void evolve(Hero hero)
        {
            hero.strength = hero.strength + (hero.strength / 2);
            hero.intelligence = hero.intelligence + (hero.intelligence / 2);
            hero.stamina = hero.stamina + (hero.stamina / 2);
        }
    }
}
