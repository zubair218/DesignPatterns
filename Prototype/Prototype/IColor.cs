﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
    {
    internal interface IColor
        {
        public void colorName ();
        public IColor clone();

        }
    }
