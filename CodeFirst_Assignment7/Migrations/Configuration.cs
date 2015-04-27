namespace CodeFirst_Assignment7.Migrations
{
    using CodeFirst_Assignment7.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst_Assignment7.Models.OrderContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CodeFirst_Assignment7.Models.OrderContext context)
        {

            var Product = new List<Product> {
                new Product{ProductID=1, ProductName = "Toblerone", UnitPrice = 3, UnitsInStock = 100},
                new Product{ProductID=2, ProductName = "M&M", UnitPrice = 5, UnitsInStock = 250},
                new Product{ProductID=3, ProductName = "Kinder Joy", UnitPrice = 7, UnitsInStock = 96},
                new Product{ProductID=4, ProductName = "Turbo", UnitPrice = 2, UnitsInStock = 27},
                new Product{ProductID=5, ProductName = "Fruit&Nuts", UnitPrice = 11, UnitsInStock = 553},
                new Product{ProductID=6, ProductName = "ChocoLava", UnitPrice = 15, UnitsInStock = 723}};

            Product.ForEach(p => context.Products.AddOrUpdate(s => s.ProductName, p));
            context.SaveChanges();

       
        }
    }
}
