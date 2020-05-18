namespace Builder
{
    public class SpecialForcesSoldierBuilder : SoldierBuilder
    {
        public SpecialForcesSoldierBuilder()
        {
            _soldier = new SpecialForcesSoldier();
        }
        
        public override void Gun()
        {
            _soldier.ChooseGun("Fuzil");
        }

        public override void Transport()
        {
            _soldier.ChooseTransport("Carro de operaçoes especiais");
        }

        public override void AtkPoint()
        {
            _soldier.DefineAtkPoint("Combate em solo");
        }
    }
}