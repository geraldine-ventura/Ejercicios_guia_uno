using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int numero = 2;

            Console.WriteLine("Los primeros 4 números perfectos son:");

            while (contador < 4)
            {
                if (!EsPrimo(numero) && EsNumeroPerfecto(numero))
                {
                    Console.WriteLine(numero);
                    contador++;
                }
                numero++;
            }
        }

        // Función para verificar si un número es primo
        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        // Función para verificar si un número es perfecto
        static bool EsNumeroPerfecto(int numero)
        {
            int sumaDivisores = 1; // Inicializamos la suma con 1 ya que 1 es divisor de todos los números

            for (int i = 2; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    sumaDivisores += i;
                }
            }

            return sumaDivisores == numero;
        }
    }
}
