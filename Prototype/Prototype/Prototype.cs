using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
    {
    internal class Prototype
        {
        public static void Main (string[] args)
            {
            IColor color = new Color("Black");
            color.colorName();
            }
        }
    }
