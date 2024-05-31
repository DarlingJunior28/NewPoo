


using Practica02;
using System;

namespace Practica02
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Persona persona = new Persona();

            persona.Nombre = "Juan";
            persona.Edad = 25;
            persona.Grado = "6to";


            Estudiantes estudiantes = new Estudiantes();
            estudiantes.Grado = "6to";


            Libros libros = new Libros();

            libros.Titulo = "El peor";
            libros.Autor = "Juan jose";
            libros.Paginas = 230;


            libros.MetodoLibro();

            Console.WriteLine("------------------------------------------------------");

            estudiantes.MetodoStuden();

            Console.WriteLine("------------------------------------------------------");

            persona.MetodoPersona();







            Console.ReadLine();
        }
       
    }
}
