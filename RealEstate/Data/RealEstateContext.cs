using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RealEstate.Models
{
    public class RealEstateContext : DbContext
    {
        public RealEstateContext (DbContextOptions<RealEstateContext> options)
            : base(options)
        {
        }

        public DbSet<RealEstate.Models.Property> Property { get; set; }
    }
}
