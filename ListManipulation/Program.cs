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
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personelist = new List<Persona>();
            List<Informatici> informaticilist = new List<Informatici>();
            List<Professori> professorilist = new List<Professori>();
            List<Elettricisti> eletriccistilist = new List<Elettricisti>();
            List<Studente> studentilist = new List<Studente>();


            for (int i = 0; i < 3; i++)
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

                        personelist.Add(studenteIns);
                        studentilist.Add(studenteIns);
                        break;

                    case 1:
                        Informatici informaticiIns = new Informatici();
                        informaticiIns.Nome = nome;
                        informaticiIns.Cognome = cognome;
                        Console.WriteLine("inserire Linguaggio di Programmazione");
                        informaticiIns.LinguaggioProg = Console.ReadLine();

                        personelist.Add(informaticiIns);
                        informaticilist.Add(informaticiIns);
                        break;

                    case 2:
                        Elettricisti elettricistiIns = new Elettricisti();
                        elettricistiIns.Nome = nome;
                        elettricistiIns.Cognome = cognome;
                        Console.WriteLine("inserire Posto di Lavoro");
                        elettricistiIns.SitoLavoro = Console.ReadLine();

                        personelist.Add(elettricistiIns);
                        eletriccistilist.Add(elettricistiIns);
                        break;

                    case 3:
                        Professori professoriIns = new Professori();
                        professoriIns.Nome = nome;
                        professoriIns.Cognome = cognome;
                        Console.WriteLine("inserire Materia d'insegnamento");
                        professoriIns.MateriaInseg = Console.ReadLine();

                        personelist.Add(professoriIns);
                        professorilist.Add(professoriIns);
                        break;
                }
            }
            Console.WriteLine("In totale ci sono: {0} persone di cui:" +
            "\nStudenti: {1}" +
            "\nInformatici: {2}" +
            "\nElettricisti: {3}" +
            "\nProfessori: {4}",
            personelist.Count, studentilist.Count, informaticilist.Count, eletriccistilist.Count, professorilist.Count);


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
                    foreach (var studente in personelist)
                    {
                        
                        bool contains = studentilist.Contains(studente);
                        if (contains)
                        {                           
                            Console.WriteLine(studente.ToString());
                        }
                    }
                    break;
                case 1:
                    foreach (var informatico in personelist)
                    {
                        bool contains = informaticilist.Contains(informatico);
                        if (contains)
                        {
                            Console.WriteLine(informatico.ToString());
                        }
                    }
                    break;
                case 2:
                    foreach (var elettricista in personelist)
                    {
                        bool contains = eletriccistilist.Contains(elettricista);
                        if (contains)
                        {
                            Console.WriteLine(elettricista.ToString());
                        }
                    }
                    break;
                case 3:
                    foreach (var professore in personelist)
                    {
                        bool contains = professorilist.Contains(professore);
                        if (contains)
                        {
                            Console.WriteLine(professore.ToString());
                        }
                    }
                    break;
                case 4:
                    foreach (var persona in personelist)
                    {                        
                        Console.WriteLine(persona.ToString());                        
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}