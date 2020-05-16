using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IBaseFactory factory;
            Console.Write("Escolha um dos personagens: 1 - Protoss | 2 - Zergs | 3 - Terranos ");

            switch (Console.ReadLine())
            {
                case "1":
                    factory = new ProtossBaseFactory();
                    break;
                case "2":
                    factory = new ZergBaseFactory();
                    break;
                case "3":
                    factory = new TerraBaseFactory();
                    break;
            }

            Console.ReadLine();
        }
    }
}