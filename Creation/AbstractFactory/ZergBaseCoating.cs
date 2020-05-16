using System;

namespace AbstractFactory
{
    public class ZergBaseCoating : ICoating
    {
        public void Composition()
        {
            Console.WriteLine("Base revestida pela cor vermelha");
        }
    }
}