using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlantPlanet.Models;

namespace PlantPlanet.Data
{
    public class PlantPlanetContext : DbContext
    {
        public PlantPlanetContext (DbContextOptions<PlantPlanetContext> options)
            : base(options)
        {
        }

        public DbSet<PlantPlanet.Models.Product> Product { get; set; }

        public DbSet<PlantPlanet.Models.Category> Category { get; set; }

        public DbSet<PlantPlanet.Models.Customer> Customer { get; set; }

        public DbSet<PlantPlanet.Models.DeliveryType> DeliveryType { get; set; }

        public DbSet<PlantPlanet.Models.Employee> Employee { get; set; }

        public DbSet<PlantPlanet.Models.Order> Order { get; set; }

        public DbSet<PlantPlanet.Models.OrderItem> OrderItem { get; set; }

        public DbSet<PlantPlanet.Models.Premuim> Premuim { get; set; }

        public DbSet<PlantPlanet.Models.ProductReview> ProductReview { get; set; }

        public DbSet<PlantPlanet.Models.SubCategory> SubCategory { get; set; }

        public DbSet<PlantPlanet.Models.Supplier> Supplier { get; set; }

        public DbSet<PlantPlanet.Models.User> User { get; set; }
    }
}
