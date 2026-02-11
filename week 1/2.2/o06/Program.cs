static class Program
{
    static void Main()
    {
        int size;

        do
        {
            Console.WriteLine("What size board do you want?");
            size = Convert.ToInt32(Console.ReadLine());
        } while (size < 2);

        int rnc = size * 2;

        for (int i = 0; i < rnc; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("W");
            }
            else
            {
                Console.Write("B");
            }

            for (int j = 0; j < rnc; j++)
            {
                if ((j + 1) / size == 2)
                {
                    Console.Write("\n");
                }
            }
        }
    }
}