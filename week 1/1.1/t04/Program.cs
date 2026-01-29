static class Program
{
    static void Main()
    {
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the age of the student next to you?");
        int student_age = Convert.ToInt32(Console.ReadLine());

        if (age > student_age)
        {
            Console.WriteLine("You are older");
        }
        else if (age < student_age)
        {
            Console.WriteLine("You are younger");
        }
        else
        {
            Console.WriteLine("Your ages are equal");
        }
    }
}
