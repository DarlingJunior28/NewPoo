using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02
{
    public class Libros
    {



        public string Titulo {  get; set; }
        public string Autor {  get; set; }
        public int Paginas { get; set; }


        public void MetodoLibro()
        {
            Console.WriteLine($"Titulo: {Titulo}, Autor: {Autor}, Paginas: {Paginas}");
        }

    }
}
