using System;

namespace AbstractFactory
{
    public class ProtossBaseEnergy : IEnergy
    {
        public void Composition()
        {
            Console.WriteLine("Energia de sustentação da base com cristais");
        }
    }
}