using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
    {
    internal class Builder
        {
        static public void Main (String[] args)
            {
            IHouseBuilder hutBuilder = new Hut();
            CivilEngineer engineer = new CivilEngineer(hutBuilder);

            engineer.constructHouse();

            House house = engineer.getHouse();

            Console.WriteLine("Engineer Designed " +house);
            }
        }
    }
