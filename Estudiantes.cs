using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02
{
    public class Estudiantes : Persona
    {

        public string Grado{ get; set; }

        public void MetodoStuden()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Grado: {Grado}");
        }
    }

}
