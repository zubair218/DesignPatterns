using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
    {
    internal class Color : IColor
        {
        private string colorName;
        public Color (string colorName)
            {
            this.colorName = colorName;
            }

        public void setColorName (string colorName)
            {
            this.colorName = colorName;
            }

        public IColor clone ()
            {
            Color newColor= new Color (this.colorName);
            return newColor;
            }

        void IColor.colorName ()
            {
            Console.WriteLine (this.colorName);
            }
        }
    }
