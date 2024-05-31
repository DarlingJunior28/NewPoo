using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public string Grado { get; set; }

        public void MetodoPersona()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Grado: {Grado}");
        }

    }


}
