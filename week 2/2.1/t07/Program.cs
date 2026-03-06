static class Program
{
    static void Main()
    {
        /*Create a List of Pets here:
         *- a Dog named Nugent
         *- a Cat named Steve
         *- a Goldfish named Brutus
         */
        List<Pet> pets = [
            new("Dog", "Nugent"),
            new("Cat", "Steve"),
            new("Goldfish", "Brutus")
        ];
        Person john = new("John", pets);

        foreach(Pet pet in john.Pets)
        {
            Console.WriteLine($"{john.Name} has a {pet.WhatAmI} named {pet.Name}");
        }
    }
}
