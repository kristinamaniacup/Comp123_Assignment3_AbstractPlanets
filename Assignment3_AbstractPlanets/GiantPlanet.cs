using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_AbstractPlanets
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
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

            //alternative way to do this => "return (this._moonCount > 0) ? true : false; 
        }

        public bool HasRings()
        {
            return (RingCount > 0) ? true : false;
        }
    }

}
