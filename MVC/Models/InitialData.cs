using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class InitialData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcClientsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcClientsContext>>()))
            {
                // Look for any Clientss.
                if (context.Clients.Any())
                {
                    return;   // DB has been seeded
                }

                context.Clients.AddRange(
                    new Clients
                    {
                        Name = "When Harry Met Sally",
                        FechaNacimiento = DateTime.Parse("1989-2-12")
                    }
                );
                context.Countries.AddRange(
                    new Country
                    {
                        Name = "When Harry Met Sally",
                        
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
