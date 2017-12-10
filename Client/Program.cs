using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.HeroesService;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HeroesServiceClient())
            {
                string school = client.GetHeroSchool("some");
                Console.WriteLine("The school is {0}", school);

                try
                {
                    //client.GetHero(null);
                    Hero hero = client.GetHero(new Work() { Worth = 100 });
                    Console.WriteLine("The name of hero: {0}", hero.Name);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
