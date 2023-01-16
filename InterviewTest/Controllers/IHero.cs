using System;
using System.Collections.Generic;

namespace InterviewTest.Controllers
{
    
	public interface IHero
	{
        Guid id { get; set; }
        string name { get; set; }

        string power { get; set; }

        public int strength { get; set; }
        public int intelligence { get; set; }
        public int stamina { get; set; }

        //List<KeyValuePair<string, int>> stats { get; set; }

        //List<HeroStats> stats { get; set; }

        //void evolve(int statIncrease = 5);

    }
}

