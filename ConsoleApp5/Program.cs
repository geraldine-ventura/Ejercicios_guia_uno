
/*Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
dos grupos de números, cuyas sumas son iguales.
El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
usuario ingrese por consola.

Nota: Utilizar estructuras repetitivas y selectivas*/

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;
            

            Console.WriteLine("Ingrese numero para particionarlo...");
            string entrada = Console.ReadLine();
            while (!int.TryParse(entrada, out numero))
            {
                Console.WriteLine("Error, ingrese numero nuevamente..");
                entrada = Console.ReadLine();
            }

            for (int i = 0; i < numero; i++)
            {

                int suma_antes = 0;
                int suma_despues = 0;

                for (int j = 1; j < i; j++)
                {

                    suma_antes += j;

                }
                for (int k = i+1; k <= numero; k++)
                {

                    suma_despues += k;
                    if (suma_despues > suma_antes)
                    {
                        break;
                    }
                }

                if (suma_antes == suma_despues)
                {

                    Console.WriteLine($"la particion del {numero}  es :{i}");

                }

               

            }

        } 
    }
}
