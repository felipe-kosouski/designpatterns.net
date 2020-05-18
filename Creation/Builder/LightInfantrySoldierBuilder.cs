namespace Builder
{
    public class LightInfantrySoldierBuilder : SoldierBuilder
    {
        public LightInfantrySoldierBuilder()
        {
            _soldier = new LightInfrantrySoldier();
        }
        
        public override void Gun()
        {
            _soldier.ChooseGun("Ataque Aereo");
        }

        public override void Transport()
        {
            _soldier.ChooseTransport("Helicoptero de ataque");
        }

        public override void AtkPoint()
        {
            _soldier.DefineAtkPoint("Resposta rápida aerea");
        }
    }
}