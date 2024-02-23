using System;
namespace Fundamentos
{
    class EntradaSalida
    {
        public static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.Read();
        }
    }
}
