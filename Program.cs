using System;
namespace CAI_SIn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Hola Mundo!");

            // Ejemplo de entrada de datos
            Console.Write("Por favor, ingrese su nombre: ");
            string nombre = Console.ReadLine();

            // Ejemplo de salida de datos
            Console.WriteLine($"Bienvenido {nombre}!");

            // Mantener la consola abierta
            Console.ReadKey();
        }
    }
}