using NinjaDomain.Classes;
using NinjaDomain.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<NinjaContext>());
            //InsertNinja();
            //InsertMultipleNinjas();
            //SimpleNinjaQueries();
            //QueryAndUpdateNinja();
            Console.ReadLine();
        }

        private static void InsertNinja()
        {
            Ninja ninja = new Ninja
            {
                Name = "JP",
                ServedInOniwaban = false,
                DateOfBirth = new DateTime(1995, 12, 11),
                ClanId = 1
            };
            using (NinjaContext context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.Add(ninja);
                context.SaveChanges();
            }
        }

        private static void InsertMultipleNinjas()
        {
            Ninja ninja1 = new Ninja
            {
                Name = "Leonardo",
                ServedInOniwaban = false,
                DateOfBirth = new DateTime(1984, 1, 1),
                ClanId = 1
            };
            Ninja ninja2 = new Ninja
            {
                Name = "Raphael",
                ServedInOniwaban = false,
                DateOfBirth = new DateTime(1985, 1, 1),
                ClanId = 1
            };
            using (NinjaContext context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.AddRange(new List<Ninja> { ninja1, ninja2 });
                context.SaveChanges();
            }
        }
        private static void SimpleNinjaQueries()
        {
            using (NinjaContext context = new NinjaContext())
            {
                List<Ninja> ninjas = context.Ninjas.ToList();
                //DbSet<Ninja> query = context.Ninjas;
                ////var someninjas = query.ToList();
                //foreach (var ninja in query)
                //{
                //    Console.WriteLine(ninja.Name);
                //}

                //IQueryable ninjas = context.Ninjas.Where(n => n.Name == "Raphael");
            }
        }

        private static void QueryAndUpdateNinja()
        {
            using(var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                Ninja ninja = context.Ninjas.FirstOrDefault();
                ninja.ServedInOniwaban = (!ninja.ServedInOniwaban);
                context.SaveChanges();
            }
        }
    }
}