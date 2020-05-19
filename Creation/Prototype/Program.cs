using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            CloudManager cloudManager = new CloudManager();
            
            cloudManager["padrao"] = new ConcreteCloud("branco", "azul");
            cloudManager["personalizada"] = new ConcreteCloud("branco", "laranja");
            
            ConcreteCloud cloudOne = cloudManager["padrao"].Clone() as ConcreteCloud;
            ConcreteCloud cloudTwo = cloudManager["padrao"].Clone() as ConcreteCloud;
            ConcreteCloud cloudThree = cloudManager["personalizada"].Clone() as ConcreteCloud;

            Console.ReadKey();
        }
    }
}