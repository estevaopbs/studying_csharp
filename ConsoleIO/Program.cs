using System;

namespace ConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int rooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] data = Console.ReadLine().Split(' ');
            Console.WriteLine("{0}\n{1}\n{2}\n{3} {4} {5}", name, rooms, preco, data[0], data[1], data[2]);
        }
    }
}