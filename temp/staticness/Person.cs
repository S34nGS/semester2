public class Person
{
    public string Name;
    public int Age;
    static readonly int MaxPeople;
    public static readonly int MaxAge;
    static Person()
    {
        MaxPeople = 120;
        MaxAge = 200;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}