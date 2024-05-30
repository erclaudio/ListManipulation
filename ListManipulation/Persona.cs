using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulation
{
    internal class Persona
    {
        public string Nome {  get; set; }
        public string Cognome { get; set; }
        public bool isStudente { get; set; }

        public Persona() { }
        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
            isStudente = false;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Cognome: {Cognome}";
        }
    }
}
