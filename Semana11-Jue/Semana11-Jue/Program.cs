using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Biblioteca;

namespace Semana11_Jue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Arreglos procesos = new Arreglos();

            procesos.Registro();
            procesos.Mostrarlista();
            Thread.Sleep(2000);
            Console.Clear();
            procesos.BuscarAlumno();
        }
    }
}
