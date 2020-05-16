using System;

namespace AbstractFactory
{
    public class ProtossBaseCoating : ICoating
    {
        public void Composition()
        {
            Console.WriteLine("Base revestida pela cor amarela");
        }
    }
}