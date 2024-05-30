using ListManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulation
{
    internal class Informatici : Persona
    {
        public string LinguaggioProg { get; set; }

        public Informatici()
        { }

        public override string ToString()
        {
            return base.ToString() + $"Linguaggio di programmazione: {LinguaggioProg}";
        }
    }
}