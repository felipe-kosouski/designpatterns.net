namespace Builder
{
    public abstract class Soldier
    {
        public string Gun { get; protected set; }
        public string Transport { get; protected set; }
        public string AtkPoint { get; protected set; }

        public abstract void ChooseGun(string gun);
        public abstract void ChooseTransport(string transport);
        public abstract void DefineAtkPoint(string atkPoint);
    }
}