using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySqlite
{
    public static class RunEntityExample
    {
        public static void RunExample()
        {
            using (var context = new ChinookContext())
            {
                var artists = from a in context.Artists
                              where a.Name.StartsWith("A")
                              orderby a.Name
                              select a;

                foreach (var artist in artists)
                {
                    Console.WriteLine(artist.Name);
                }
            }

            // ### Add a db record
            using (var context = new ChinookContext())
            {
                context.Artists.Add(
                    new Artist
                    {
                        Name = "Anberlin",
                        Albums =
                        {
                            new Album { Title = "Cities" },
                            new Album { Title = "New Surrender" }
                        }
                    });
                context.SaveChanges();
            }

            Console.ReadKey();
        }
    }
}
