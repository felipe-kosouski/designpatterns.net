namespace Builder
{
    public abstract class SoldierBuilder
    {
        protected Soldier _soldier;

        public Soldier GetSoldier()
        {
            return _soldier;
        }

        public abstract void Gun();
        public abstract void Transport();
        public abstract void AtkPoint();
    }
}