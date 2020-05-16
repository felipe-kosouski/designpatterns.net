using System;

namespace AbstractFactory
{
    public class TerraBaseCoating : ICoating
    {
        public void Composition()
        {
            Console.WriteLine("Base revestida pela cor verde");
        }
    }
}