using System;

namespace AbstractFactory
{
    public class ProtossBaseFactory : IBaseFactory
    {
        public ProtossBaseFactory()
        {
            CreateBase();
        }
        
        public void CreateBase()
        {
            Console.WriteLine("Base Protoss criada com sucesso");
            
            ProtossBaseCoating coating = new ProtossBaseCoating();
            coating.Composition();
            
            ProtossBaseEnergy energy = new ProtossBaseEnergy();
            energy.Composition();
        }
    }
}