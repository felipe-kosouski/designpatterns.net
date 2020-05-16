using System;

namespace AbstractFactory
{
    public class ZergBaseEnergy : IEnergy
    {
        public void Composition()
        {
            Console.WriteLine("Energia de sustentação da base pela Terra");
        }
    }
}