using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var army = new Army();
            SoldierBuilder soldierBuilder;
            Soldier soldier;
            
            soldierBuilder = new SpecialForcesSoldierBuilder();
            army.CreateSoldier(soldierBuilder);
            soldier = soldierBuilder.GetSoldier();
            Console.WriteLine("Soldado com as características: {0}, {1}, {2}", soldier.Gun, soldier.Transport, soldier.AtkPoint);
            
            soldierBuilder = new LightInfantrySoldierBuilder();
            army.CreateSoldier(soldierBuilder);
            soldier = soldierBuilder.GetSoldier();
            Console.WriteLine("Soldado com as características: {0}, {1}, {2}", soldier.Gun, soldier.Transport, soldier.AtkPoint);
        }
    }
}