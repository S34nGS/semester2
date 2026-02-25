static class Program
{
    static void Main()
    {
        string fName = PromptForInput("What is your first name?");
        string lName = PromptForInput("What is your last name?");

        string GetFullName (string firstName, string lastName) => $"{firstName} {lastName}";
        void DisplayFullName (string firstName, string lastName) => Console.WriteLine($"{firstName} {lastName}");

        Console.WriteLine(GetFullName(fName, lName));
        DisplayFullName(fName, lName);
    }

    // Keeps asking if the user doesn't provide an input
    static string PromptForInput(string message)
    {
        string input;
        do
        {
            Console.WriteLine(message);
            input = Console.ReadLine()!;
        } while (string.IsNullOrEmpty(input));

        return input;
    }

    // Create GetFullName and DisplayFullName here
}
