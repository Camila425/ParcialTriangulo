using ParcialTriangulo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialTriangulo.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            triangulo Triangulo = new triangulo();

            Console.Write("ingrese el ladoA:");
            int ladoA = int.Parse(Console.ReadLine());
            Console.Write("ingrese el ladoB:");
            int ladoB = int.Parse(Console.ReadLine());
            Console.Write("ingrese el ladoC:");
            int Ladoc = int.Parse(Console.ReadLine());

            Console.WriteLine($"triangulo es:{Triangulo.GetTriangulo()}");
            Console.WriteLine($"perimetro es:{triangulo.GetPerimetro()}");
         
            Console.ReadLine();
        }
    }
}
