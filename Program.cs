using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma letra:");
            string letra = Console.ReadLine().ToLower();

            switch (letra)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("Vogal");
                    break;

                default:
                    Console.WriteLine("Não é vogal");
                    break;
            }
        }
    }
}