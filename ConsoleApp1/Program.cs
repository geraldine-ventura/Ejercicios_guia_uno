namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int min = int.MaxValue;
            int max = int.MinValue;
            int acumulador = 0;
            int numero;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero ..");
                string entrada = Console.ReadLine();

                while (!int.TryParse(entrada, out numero))
                {
                    Console.WriteLine("error, introduzca un numero nuevamente");
                    entrada = Console.ReadLine();
                }
                if (numero < min)
                {
                    min = numero;
                }
                else if (numero > max)
                {
                    max = numero;
                }
                acumulador += numero;

                
            }
            int promedio = acumulador / 5;

            Console.WriteLine($"\n El min es: {min}");
            Console.WriteLine($"\n El max es: {max}");
            Console.WriteLine($"\n El promedio es: {promedio}");
            Console.ReadKey();

        }

    }
}