class Person
{
    public string Name;
    public Animal? Pet;

    public Person(string name, Animal pet)
    {
        Name = name;
        Pet = pet;
    }

    public string Info()
    {
        string info;
        if (Pet == null)
        {
            info = $"{Name} has no pet";
            return info;
        }
        info = $"{Name} has a pet that makes the sound {Pet.MakeSound()}";
        return info;
    }
}
