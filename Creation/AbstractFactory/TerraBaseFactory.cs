using System;

namespace AbstractFactory
{
    public class TerraBaseFactory : IBaseFactory
    {
        public TerraBaseFactory()
        {
            CreateBase();
        }
        public void CreateBase()
        {
            Console.WriteLine("Base Terran criada com sucesso");
            
            TerraBaseCoating coating = new TerraBaseCoating();
            coating.Composition();
            
            TerranBaseEnergy energy = new TerranBaseEnergy();
            energy.Composition();
        }
    }
}