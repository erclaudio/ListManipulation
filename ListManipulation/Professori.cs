using ListManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulation
{
    internal class Professori : Persona
    {
        public string MateriaInseg { get; set; }

        public Professori()
        { }

        public override string ToString()
        {
            return base.ToString() + $", Materia insegnata: {MateriaInseg}";
        }
    }
}