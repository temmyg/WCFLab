using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class HeroesService : IHeroesService
    {
        public string GetHeroSchool(string arena)
        {
            return string.Format("From School: Tech Colleage" );
        }

        public Hero GetHero(Work work)
        {
            if (work == null)
            {
                throw new FaultException("work not exists");
            }
            if (work.Worth > 10)
                return new Hero { Name = "Errison", arena = "Telecom" };
            else
                return null;
        }
    }
}
