using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekenwinkel.Class_Library
{
    public class Afmeting
    {
        private int Lengte;
        private int Breedte;
        private int Hoogte;

        public int lengte
        {
            get
            {
                return Lengte;
            }

            set
            {
                Lengte = value;
            }
        }

        public int breedte
        {
            get
            {
                return Breedte;
            }

            set
            {
                Breedte = value;
            }
        }

        public int hoogte
        {
            get
            {
                return Hoogte;
            }

            set
            {
                Hoogte = value;
            }
        }

        public Afmeting(int lengte, int breedte, int hoogte)
        {
            Lengte = lengte;
            Breedte = breedte;
            Hoogte = hoogte;
        }
    }
}
