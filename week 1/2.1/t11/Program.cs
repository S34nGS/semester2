static class Program
{
    static void Main()
    {
        int passed = 0;
        List<double> grades = [7, 5.5, 3.2, 10, 4.5];

        foreach (var grade in grades)
        {
            if (grade >= 5.5)
            {
                passed++;
            }
        }

        Console.WriteLine($"{passed} out of {grades.Count} students passed");
    }
}
