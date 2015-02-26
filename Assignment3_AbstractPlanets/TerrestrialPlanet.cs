using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_AbstractPlanets
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable //implements Planet base class and interfaces 
    {
        //PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private bool _oxygen; 

        //takes all parameters of Planet base class as well as local variable
        //CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public TerrestrialPlanet(bool oxygen, string name, double diameter, double mass)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen; //local variable
        }

        //returns true if mooncount is greater than zero
        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public bool HasMoons()
        {

            return (MoonCount > 0) ? true : false;
        }

        //returns local variable which will always be true
        public bool Habitable()
        {
            return this._oxygen; 
        }
    }
}
