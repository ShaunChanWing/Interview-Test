﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTest.Controllers
{
    public class Hero : IHero
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string power { get; set; }
        //public List<KeyValuePair<string, int>> stats { get; set; }
        //public void evolve(int statIncrease = 5)
        //{ 
            
        //}
    }
}
