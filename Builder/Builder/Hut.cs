using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
    {
    internal class Hut : IHouseBuilder
        {
        private House house;
        public Hut ()
            {
            this.house = new House ();
            }

        public void buildBasement ()
            {
            house.setBasement("Hut Basement");
            }

        public void buildRoof ()
            {
            house.setRoof("Hut Roof");
            }
        public House getHouse ()
            {
            return this.house;
            }
        }
    }
