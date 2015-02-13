using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_AbstractPlanets
{
    class TerrestrialPlanet : Planet
    {
        //PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++
        private bool _oxygen;

        //CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++
        public TerrestrialPlanet(bool oxygen, string name, double diameter, double mass)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }


    }
}
