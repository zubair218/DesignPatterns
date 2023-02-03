using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
    {
    internal interface IHousePlan
        {
        public void setBasement (string basement);
        public void setRoof (string roof);
        }
    }
