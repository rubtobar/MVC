using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Data
{

    public class MvcClientsContext : DbContext
    {
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Country { get; set; }

        public MvcClientsContext(DbContextOptions<MvcClientsContext> options)
            : base(options)
        {
        }

        


    }

}
