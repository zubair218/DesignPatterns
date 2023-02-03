﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
    {
    internal class CivilEngineer
        {
        private IHouseBuilder houseBuilder;
        public CivilEngineer (IHouseBuilder houseBuilder)
            {
            this.houseBuilder = houseBuilder;
            }

        public House getHouse ()
            {
            return this.houseBuilder.getHouse();
            }

        public void constructHouse ()
            {
            this.houseBuilder.buildBasement();
            this.houseBuilder.buildRoof();
            }
        }
    }
