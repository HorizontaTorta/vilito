using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RealEstateContext(
                serviceProvider.GetRequiredService<DbContextOptions<RealEstateContext>>()))
            {
                // Look for any Propertys.
                if (context.Property.Any())
                {
                    return;   // DB has been seeded
                }

                context.Property.AddRange(
                    new Property
                    {
                        Price = 100003M,
                        Address = "бул. „Цар Освободител“ 10"
                    },

                    new Property
                    {
                        Price = 932342.99M,
                        Address = "ул. „Кузман Шапкарев“ 6"
                    },

                    new Property
                    {
                        Price = 2342123.99M,
                        Address = "ул. „Иван Денкоглу“ 15Б, 1000 Център, София"
                    },

                    new Property
                    {
                        Price = 21341234.43M,
                        Address = "ул. „Позитано“ 24"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
