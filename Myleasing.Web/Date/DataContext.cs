﻿using Microsoft.EntityFrameworkCore;
using Myleasing.Web.Data.Entities;
using Myleasing.Web.Date.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myleasing.Web.Date
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Lessee> Lessees { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyImage> PropertyImages { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }


    }
}