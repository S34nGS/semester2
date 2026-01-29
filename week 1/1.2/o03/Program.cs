static class Program
{
    static void Main()
    {
        int correct = 0;

        Console.WriteLine("Answer the following MCQs:");
        Console.WriteLine("Which of the following is NOT a valid type in C#?");
        Console.WriteLine("A: bool\nB: int\nC: var\nD: string");
        string answer1 = (Console.ReadLine() ?? "").ToLower();
        if(answer1 == "c")
        {
            correct += 1;
        }

        Console.WriteLine("What happens if you execute the following line C#?");
        Console.WriteLine("int x = 1.23;");
        Console.WriteLine("A: x will be 1.23\nB: x will be 1\nC: x will be 1.0\nD: you will get a compiler error");
        string answer2 = (Console.ReadLine() ?? "").ToLower();
        if(answer2 == "d")
        {
            correct += 1;
        }

        Console.WriteLine("Consider the following line:");
        Console.WriteLine("double d = 1.23;");
        Console.WriteLine("What are TWO ways to convert variable d to an int?");
        Console.WriteLine("A: int i = (int)d;\nB: int i = int(d)\nC: int i = 0 + d\nD: int i = Convert.ToInt32(d)");
        Console.WriteLine("Your first answer:");
        string answer3 = (Console.ReadLine() ?? "").ToLower();
        Console.WriteLine("Your second answer:");
        string answer4 = (Console.ReadLine() ?? "").ToLower();
        if ((answer3 == "a" && answer4 == "d") || (answer3 == "d" && answer4 == "a"))
        {
            correct += 1;
        }

        if (correct == 3)
        {
            Console.WriteLine($"Your score: {correct} out of 3. Well done!");
        }
        else
        {
            Console.WriteLine($"Your score: {correct} out of 3.");
        }
    }
}
