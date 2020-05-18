namespace Builder
{
    public class SpecialForcesSoldier : Soldier
    {
        public override void ChooseGun(string gun)
        {
            Gun = gun;
        }

        public override void ChooseTransport(string transport)
        {
            Transport = transport;
        }

        public override void DefineAtkPoint(string atkPoint)
        {
            AtkPoint = atkPoint;
        }
    }
}