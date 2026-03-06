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
        foreach(Pet pet in pets)
        {
            Console.WriteLine($"I have a {pet.WhatAmI} named {pet.Name}");
        }
    }
}
