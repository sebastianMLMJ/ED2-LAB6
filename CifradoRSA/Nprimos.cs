using System;
using System.Collections.Generic;
using System.Text;

namespace CifradoRSA
{
    class Nprimos
    {
        public static bool esNumeroPrimo(int n)
        {
            if (n > 1)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        private static List<int> obtenerCoprimos(int n)
        {
            //Lista de numeros
            List<int> numeros = new List<int>();

            for (int i = 2; i < n; i++)
            {
                numeros.Add(i);
            }

            //Factorizar
            List<int> factores = new List<int>();

            if (n % 2 == 0) //si es un numero par
            {
                factores.Add(2);
            }

            for (int i = 3; i < n / 2; i += 2)
            {
                if (n % i == 0)
                {
                    factores.Add(i);
                }
            }

         
            return numeros;
        }

        

    }
}
