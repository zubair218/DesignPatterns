using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
    {
    internal class House : IHousePlan
        {
        private string basement;
        private string roof;

        public void setBasement (string basement)
            {
            this.basement = basement;
            }

        public void setRoof (string roof)
            {
            this.roof = roof;
            }
        public String getBasement ()
            {
            return this.basement;
            }
        public String getRoof ()
            {
            return this.roof; 
            }
        }
    }
