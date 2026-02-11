static class Program
{
    static void Main()
    {
        List<double> grades = [6.5, 9.5, 4, 5, 4.5, 10, 7.1];

        for (int i = 0; i < grades.Count - 1; i++)
        {
            Console.WriteLine(grades[i]);
            if (grades[i] < 5.5)
            {
                string? answer;
                do
                {
                    Console.WriteLine("Retake this course? y/n");
                    answer = (Console.ReadLine() ?? "").ToLower();
                    if (answer == "y")
                    {
                        grades[i]++;
                        Console.WriteLine($"Grade: {grades[i]}");
                        break;
                    }
                    else if (answer == "n")
                    {
                        break;
                    }
                } while (answer != "y" || answer != "n");
            }
        }
        Console.WriteLine("Final grades:");
        foreach (var grade in grades)
        {
            Console.WriteLine(grade);
        }
    }
}