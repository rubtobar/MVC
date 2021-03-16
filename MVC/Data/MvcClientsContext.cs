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
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<TipoHotel> TipoHotel { get; set; }

        public MvcClientsContext(DbContextOptions<MvcClientsContext> options)
            : base(options)
        {
        }

        


    }

}
