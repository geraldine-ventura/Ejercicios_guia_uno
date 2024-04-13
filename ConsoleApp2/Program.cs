/*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
Nota: Utilizar el método */
using System;
namespace ConsoleApp2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int numero;
            int cuadrado;
            int cubo;

            Console.WriteLine("Ingrese dos numeros..");
            string entrada= Console.ReadLine();

            while ( !int.TryParse(entrada, out numero) || numero <= 0) 
            {

                Console.WriteLine("Error ingrese nuevamente num");
                entrada = Console.ReadLine();
            }
                
            cuadrado =(int) Math.Pow(numero, 2);
            cubo = (int)Math.Pow(numero, 3);
                    
            Console.WriteLine($"El cuadrado es :{cuadrado}");

            Console.WriteLine($"El cubo es :{cubo}");

        }
    }
}
