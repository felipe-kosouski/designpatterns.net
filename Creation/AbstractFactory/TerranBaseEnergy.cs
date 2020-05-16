using System;

namespace AbstractFactory
{
    public class TerranBaseEnergy : IEnergy
    {
        public void Composition()
        {
            Console.WriteLine("Energia de sustentação da base mecânica");
        }
    }
}