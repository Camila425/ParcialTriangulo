using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialTriangulo.Entidades
{
    public class triangulo
    {
        private static int ladoA;
        private static int ladoB;
        private static int Ladoc;

        public triangulo(int ladoa, int ladob, int ladoc)
        {
            ladoA = ladoa;
            ladoB = ladob;
            Ladoc = ladoc;
        }

        public triangulo()
        {
            ladoA = 1;
            ladoB = 1;
            Ladoc = 1;
        }


        public static bool Validar()
        {
            return ladoA + ladoB > Ladoc && ladoA + Ladoc > ladoB && ladoB + Ladoc > ladoA;
        }

        public string GetTriangulo()
        {
            string Resultado = "";

            if (Math.Pow(ladoA,2)==Math.Pow(ladoB, 2) + Math.Pow(Ladoc, 2))
            {
                Resultado=("triangulo rectangulo");
            }
            if (Math.Pow(ladoA,2) > Math.Pow(ladoB, 2) + Math.Pow(Ladoc, 2))
            {
                Resultado=("triangulo obtusangulo");
            }

            if (Math.Pow(ladoA, 2)< Math.Pow(ladoB, 2) + Math.Pow(Ladoc, 2))
            {
                Resultado=("triangulo acutángulo");
            }
            return Resultado;
        }

        public static double GetPerimetro()
        {

            return ladoA + ladoB + Ladoc;
        }

        public static double SemiPerimetro()
        {
            return (ladoA + ladoB + Ladoc) / 2;
        }




    }
}
