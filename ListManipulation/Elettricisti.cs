using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulation
{
    internal class Elettricisti : Persona
    {
        public string SitoLavoro { get; set; }

        public Elettricisti()
        { }

        public override string ToString()
        {
            return base.ToString() + $", Posto di lavoro: {SitoLavoro}";
        }
    }
}