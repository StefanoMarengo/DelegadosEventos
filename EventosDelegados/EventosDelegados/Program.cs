using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosDelegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.setNombre("Juancito");//set nombreDefault


            persona.ActualizacionNombre("Pepe");
            persona.NombreModificado += Logger;



        }
        static void Logger(object sender, NombreEventArgs e)
        {
            Console.WriteLine($"El nombre fue modificado de {e.NombreAntiguo} a {e.NombreNuevo}");
        }
    }
}
