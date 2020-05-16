using System;

namespace AbstractFactory
{
    public class ZergBaseFactory : IBaseFactory
    {
        public ZergBaseFactory()
        {
            CreateBase();
        }
        
        public void CreateBase()
        {
            Console.WriteLine("Base Zerg Criada com Sucesso");
            
            ZergBaseCoating coating = new ZergBaseCoating();
            coating.Composition();
            
            ZergBaseEnergy energy = new ZergBaseEnergy();
            energy.Composition();
        }
    }
}