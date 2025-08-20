using Directorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Declaracion de objeto list
            List<string> frutas = new List<string>();

            frutas.Add("Manzana");
            frutas.Add("Pera");

            //Console.WriteLine(frutas[0]);
            //Console.WriteLine(frutas[1]);

            //Estructura de repeticion for each para recorrer una lista
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
            */

            List<Persona> personas = new List<Persona>();

            Persona per1 = new Persona("Gabriel", "Garcia Marquez");
            Persona per2 = new Persona("Jose", "Saramargo");

            personas.Add(per1);
            personas.Add(per2);

            foreach (Persona per in personas)
            {
                Console.WriteLine(per.getNombreCompleto());
            }

            Console.ReadLine();



        }

        
             
            //Estos es lo que habiamos hecho anteriormente

            static void ejemploClassPersona()
        {

            Persona persona = new Persona();
            Marcador marcador = new Marcador();


            string nombreCompleto = string.Empty;

            persona.setNombre("Pedro Antonio");
            persona.setApellidos("Perez Perez");

            nombreCompleto = persona.getNombreCompleto();
            Console.WriteLine("Persona 1" + " " + nombreCompleto + " " + "Salario: " + marcador.getSalario(44 * 4));

            nombreCompleto = persona.getNombreCompleto("Jose Cecilio ", "Del Valle");

            Console.WriteLine("Persona 2" + " " + nombreCompleto + " " + "Salario: " + marcador.getSalario(35 * 4));

                Console.ReadLine();



        }
            

    
    }
}
