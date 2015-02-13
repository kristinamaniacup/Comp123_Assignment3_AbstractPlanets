using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_AbstractPlanets
{
    class GiantPlanet : Planet
    {
        //PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++
        private string _type;


        //CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public GiantPlanet(string type, string name, double diameter, double mass)
            : base(name, diameter, mass)
        {
            this._type = type;
        }

        //PUBLIC METHOD(S) +++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public bool HasMoons()
        {
            
            if(MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
