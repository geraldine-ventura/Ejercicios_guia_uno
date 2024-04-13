/*
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
por consola.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/


namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un número hasta donde desee ver los num primos:");
            string entrada = Console.ReadLine();

            //TryParse() devuelve true  si la conversión es exitosa y almacena el resultado en la variable numero//
            // ejem num 7 , ![TryParse(entrada(true))]=false osea que no se cumple la cond del while => NotFiniteNumberException entra en el buble//

            while (!int.TryParse(entrada, out numero) || numero <= 1)//sí la "str entrada" no se puede parsear y es <=1 "true"
            {
                Console.WriteLine("Error. Por favor, ingrese un número entero mayor que 1:");
                entrada = Console.ReadLine();//se pide ingresar nuevamente 
            }

            Console.WriteLine("Números primos hasta " + numero + ":");

            for (int i = 2; i <= numero; i++)
            {
                if (EsPrimo(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        // Función para verificar si un número es primo
        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }
            //Para determinar si un número es primo, necesitamos verificar si tiene algún divisor diferente de 1 y de sí mismo.
            for (int i = 2; i <= Math.Sqrt(numero); i++)// solo necesitas verificar los divisores
                                                        // hasta su raíz cuadrada. Si no hay divisores
                                                        // hasta la raíz cuadrada, entonces no habrá divisores mayores
                                                        // y el número es primo
            {
                if (numero % i == 0)
                {
                    return false;//4 no es primo
                }
            }

            return true;// es primo
        }
    }
}

