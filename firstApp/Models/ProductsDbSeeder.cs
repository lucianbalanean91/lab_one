using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstApp.Models
{
    public class ProductsDbSeeder
    {
        public static void Initialize(ProductsDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any flowers.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            context.Products.AddRange(
                new Product
                {
                    Name = "Zahar",
                    Description = "Cantitate mica",
                    Category = "Alimentar",
                    Price = 20.5
        },
                new Product
                {
                    Name = "Faina",
                    Description = "Cantitate mare",
                    Category = "Alimentar",
                    Price = 5.3
                    
                },
                 new Product
                 {
                     Name = "Apa",
                     Description = "Se consuma in fiecare zi",
                     Category = "Alimentar",
                     Price = 10

                 }
            );
            context.SaveChanges();
        }
    }
}
