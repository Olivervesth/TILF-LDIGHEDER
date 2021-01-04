using System;

namespace Substitution_kryptering
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Encrypter e = new Encrypter();
                Console.WriteLine("Encrypt");
                Console.WriteLine(e.Encrypt(Console.ReadLine()));
                Console.ReadKey();
                Console.WriteLine("Decrypt");
                Console.WriteLine(e.Decrypt(Console.ReadLine()));
                Console.ReadKey();

            }

        }
    }
}
