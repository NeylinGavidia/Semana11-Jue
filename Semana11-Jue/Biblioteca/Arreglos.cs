using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Arreglos
    {
        string[] listanombres = new string[4]; //los arreglos van antes de las clases
        public void Registro() //aqui vamos registrar los nombre
        {
            for (int i = 0; i < listanombres.Length; i++) 
            {
               
                Console.Write("Por favor ingresa estudiante " + (i+1) + ": ");
                listanombres[i] = Console.ReadLine();
                Console.WriteLine();
             
            }
        }
        public void Mostrarlista()
        {
            Console.WriteLine("La lista de estudiantes que asistió es:");
            for (int i = 0; i < listanombres.Length; i++)
            {
                Console.WriteLine($"{(i + 1)}. {listanombres[i]}"); //se debe poner en llaves y entre comillas todo el mensaje para que se pueda numerar
            }
        }
        public void BuscarAlumno()
        {
            Console.Write("Ingrese nombre del alumno: ");
            string estudiante = Console.ReadLine();
            Console.WriteLine();
            bool asistente = false;
            for (int i = 0; i < listanombres.Length; i++)
            {
                if (estudiante == listanombres[i]) //comparar a los valores de la lista
                {
                    Console.WriteLine(listanombres[i] + ", si asitió");
                    asistente = true;
                    /*return;*///para finalizar el proceso
                }
            }
            //validar si encuentra o no un alumno coincidente
            if (asistente == false)
            {
                Console.WriteLine("No asistió");
            }
        }
    }
}
