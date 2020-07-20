﻿using MadhuShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadhuShop.DataLayer
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Cloth> Clothes { get; set; }
        public DbSet<Category> Catogory { get; set; }
        public DbSet<ApplicationType> ApplicationType { get; set; }
    }
}
