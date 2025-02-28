﻿using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

public class MyDbContext : DbContext
{
    public DbSet<ToDos>? ToDos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=ToDos.db");
    }

}

