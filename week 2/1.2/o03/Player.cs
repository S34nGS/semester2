public class Player
{
    public string Name;
    public int HealthPoints;
    public int Power;
    public Player(string name, int power)
    {
        Name = name;
        HealthPoints = 100;
        Power = power;
    }

    public bool IsAlive()
    {
        return HealthPoints > 0;
    }

    public void TakeDamage(int damage)
    {
        if (IsAlive())
        {
            HealthPoints-=damage;
        }
        if (HealthPoints < 0)
        {
            HealthPoints = 0;
        }
    }
}