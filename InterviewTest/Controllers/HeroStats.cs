using System;
using Microsoft.EntityFrameworkCore;

namespace InterviewTest.Controllers
{
  
	public class HeroStats
	{
        //public string id { get; set; }

        public int id { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int stamina { get; set; }

    }
}

