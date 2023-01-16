using System;
using System.Collections.Generic;

namespace InterviewTest.Controllers.Models
{
	public class AddHero
	{
        public string name { get; set; }
        public string power { get; set; }

        //public string id { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int stamina { get; set; }
        //public List<KeyValuePair<string, int>> stats { get; set; }
    }
}

