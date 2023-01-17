﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day4MVC.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=conn")

        {

        }

        public DbSet<Account> Accounts { get; set; }
    }
}