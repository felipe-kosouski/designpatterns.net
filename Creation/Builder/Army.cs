namespace Builder
{
    public class Army
    {
        public void CreateSoldier(SoldierBuilder soldierBuilder)
        {
            soldierBuilder.Gun();
            soldierBuilder.Transport();
            soldierBuilder.AtkPoint();
        }
    }
}