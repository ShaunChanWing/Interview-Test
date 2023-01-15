using System;
using System.Collections.Generic;

namespace InterviewTest.Controllers.Models
{
	public class AddHero
	{
        public string name { get; set; }
        public string power { get; set; }
        public List<KeyValuePair<string, int>> stats { get; set; }
    }
}

