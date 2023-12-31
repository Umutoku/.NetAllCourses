﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Directory.MAP.Configurations;
using Directory.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Directory.DAL.Context
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
        }
        public DbSet<Person> Persons { get; set; }
    }
}
