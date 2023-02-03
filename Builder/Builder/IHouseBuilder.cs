using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
    {
    internal interface IHouseBuilder
        {
        public void buildBasement ();
        public void buildRoof ();
        public House getHouse ();
        }
    }
