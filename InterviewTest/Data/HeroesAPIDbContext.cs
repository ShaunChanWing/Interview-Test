using System;
using InterviewTest.Controllers;
using Microsoft.EntityFrameworkCore;

namespace InterviewTest.Data
{
    public class HeroesAPIDbContext : DbContext
    {
        public HeroesAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hero> Heroes { get; set; }
    }
}

