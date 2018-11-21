
using System;
using System.Linq;
using NLayerApp.DAL.Entities;

namespace NLayerApp.DAL.Migrations
{
    using System.Data.Entity.Migrations;


    public sealed class Configuration : DbMigrationsConfiguration<NLayerApp.DAL.EF.MobileContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "NLayerApp.DAL.EF.MobileContext";
        }
        protected override void Seed(NLayerApp.DAL.EF.MobileContext context)
        {

            using (var dbContextTransaction = context.Database.BeginTransaction())
            {
                try
                {
                    if (!context.Phones.Any())
                    {
                        context.Phones.Add(new Phone {Name = "Nokia Lumia 630", Company = "Nokia", Price = 220});
                        context.Phones.Add(new Phone {Name = "iPhone 6", Company = "Apple", Price = 320});
                        context.Phones.Add(new Phone {Name = "LG G4", Company = "lG", Price = 260});
                        context.Phones.Add(new Phone {Name = "Samsung Galaxy S 6", Company = "Samsung", Price = 300});
                        context.SaveChanges();
                    }

                    dbContextTransaction.Commit();

                }
                catch (Exception)
                {
                    dbContextTransaction.Rollback();
                    throw;
                }
            }
        }

    }
}
