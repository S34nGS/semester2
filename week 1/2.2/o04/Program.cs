public class Program
{
    static void Main()
    {
        int startNumber = Convert.ToInt32(Console.ReadLine());
        int endNumber = Convert.ToInt32(Console.ReadLine());

        for (int start = startNumber; start < endNumber + 1; start++)
        {
            if (start % 3 == 0 && start % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (start % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (start % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(start);
            }
        }
    }
}