/*using ListManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulation
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Persona> persone = new List<Persona>();
            List<Studente> studenti = new List<Studente>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Inserire Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Inserire Cognome");
                string cognome = Console.ReadLine();
                Console.WriteLine("è uno studente? \n0- si \n1- no");
                int selezione = int.Parse(Console.ReadLine());
                if (selezione == 0)
                {
                    // Create an instance of Studente if the person is a student
                    Studente studenteIns = new Studente();
                    studenteIns.Nome = nome;
                    studenteIns.Cognome = cognome;
                    studenteIns.isStudente = true;

                    Console.WriteLine("Inserire Matricola");
                    studenteIns.Matricola = int.Parse(Console.ReadLine());
                    studenti.Add(studenteIns);
                    persone.Add(studenteIns);
                }
                else
                {
                    // Create an instance of Persona if the person is not a student
                    Persona personaIns = new Persona();
                    personaIns.Nome = nome;
                    personaIns.Cognome = cognome;
                    personaIns.isStudente = false;

                    persone.Add(personaIns);
                }
            }

            foreach (var persona in persone) 
            {
                bool contains = studenti.Contains(persona);
                if (contains)
                {
                    //Studente obj = (Studente)persona;
                    //Console.WriteLine(obj.Matricola);
                    Console.WriteLine(persona.ToString());
                }
                
            }
            Console.ReadLine();
        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> persone = new List<Persona>();

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Inserire Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Inserire Cognome");
                string cognome = Console.ReadLine();

                Console.WriteLine("Che tipo di persona vuoi aggiungere? " +
                    "\n0- studente " +
                    "\n1- informatico " +
                    "\n2- elettricista" +
                    "\n3- professore");
                int selezione = int.Parse(Console.ReadLine());


                switch (selezione)
                {
                    case 0:
                        Studente studenteIns = new Studente();
                        studenteIns.Nome = nome;
                        studenteIns.Cognome = cognome;
                        studenteIns.isStudente = true;
                        Console.WriteLine("Inserire Matricola");
                        studenteIns.Matricola = int.Parse(Console.ReadLine());

                        persone.Add(studenteIns);
                        break;

                    case 1:
                        Informatici informaticiIns = new Informatici();
                        informaticiIns.Nome = nome;
                        informaticiIns.Cognome = cognome;
                        Console.WriteLine("inserire Linguaggio di Programmazione");
                        informaticiIns.LinguaggioProg = Console.ReadLine();

                        persone.Add(informaticiIns);
                        break;

                    case 2:
                        Elettricisti elettricistiIns = new Elettricisti();
                        elettricistiIns.Nome = nome;
                        elettricistiIns.Cognome = cognome;
                        Console.WriteLine("inserire Posto di Lavoro");
                        elettricistiIns.SitoLavoro = Console.ReadLine();

                        persone.Add(elettricistiIns);
                        break;

                    case 3:
                        Professori professoriIns = new Professori();
                        professoriIns.Nome = nome;
                        professoriIns.Cognome = cognome;
                        Console.WriteLine("inserire Materia d'insegnamento");
                        professoriIns.MateriaInseg = Console.ReadLine();

                        persone.Add(professoriIns);
                        break;
                }
            }
            Console.WriteLine("Quale gruppo di persone vuoi estrarre?" +
                        "\n0- studente " +
                        "\n1- informatico " +
                        "\n2- elettricista" +
                        "\n3- professore" +
                        "\n4- tutti");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 0:
                    foreach (var studente in persone)
                    {
                        if (studente is Studente && persone.Contains(studente))
                        {
                            Studente obj = (Studente)studente;
                            Console.WriteLine(obj.ToString());
                        }
                    }
                    break;
                case 1:
                    foreach (var informatico in persone)
                    {
                        if (informatico is Informatici && persone.Contains(informatico))
                        {
                            Informatici obj = (Informatici)informatico;
                            Console.WriteLine(obj.ToString());
                        }
                    }
                    break;
                case 2:
                    foreach (var elettricista in persone)
                    {
                        if (elettricista is Elettricisti && persone.Contains(elettricista))
                        {
                            Elettricisti obj = (Elettricisti)elettricista;
                            Console.WriteLine(obj.ToString());
                        }
                    }
                    break;
                case 3:
                    foreach (var professore in persone)
                    {
                        if (professore is Professori && persone.Contains(professore))
                        {
                            Professori obj = (Professori)professore;
                            Console.WriteLine(obj.ToString());
                        }
                    }
                    break;
                case 4:
                    foreach (var persona in persone)
                    {                        
                        Console.WriteLine(persona.ToString());                        
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}