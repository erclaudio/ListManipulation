using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulation
{
    internal class Studente : Persona
    {
        public int Matricola {  get; set; }
        public Studente() { }        
        
        public override string ToString()
        {
            return base.ToString() + $", Matricola: {Matricola}";
        }
    }
}
