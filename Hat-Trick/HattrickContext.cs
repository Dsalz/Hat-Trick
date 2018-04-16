using Hat_Trick.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

public class HattrickContext : DbContext
{
    // You can add custom code to this file. Changes will not be overwritten.
    // 
    // If you want Entity Framework to drop and regenerate your database
    // automatically whenever you change your model schema, please use data migrations.
    // For more information refer to the documentation:
    // http://msdn.microsoft.com/en-us/data/jj591621.aspx

    public HattrickContext() : base("name=HattrickContext")
    {
    }

    public System.Data.Entity.DbSet<Hat_Trick.Models.Player> Players { get; set; }

    public System.Data.Entity.DbSet<Hat_Trick.Models.Club> Clubs { get; set; }

    public System.Data.Entity.DbSet<Hat_Trick.Models.League> Leagues { get; set; }

    public DbSet<Country> Countries { get; set; }
}
