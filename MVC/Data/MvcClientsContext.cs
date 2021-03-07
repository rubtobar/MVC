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
            public MvcClientsContext(DbContextOptions<MvcClientsContext> options)
                : base(options)
            {
            }

            public DbSet<Clients> Clients { get; set; }
        }
    
}
