static class Program
{
    static void Main()
    {
        Console.WriteLine("What is the initial balance in whole Euros?");
        double balance = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the interest rate in percent?");
        double interestPct = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Calculate over how many years?");
        int years = Convert.ToInt32(Console.ReadLine());

        // Your tax code goes here
        double taxesPaid = 0;
        
        for (int year = 0; year < years; year++)
        {
            balance += balance * (interestPct / 100);

            double taxes = 0;

            if (balance >= 50000 && balance <= 100000)
            {
                taxes = (balance - 50000) * 0.015;
            }
            else if (balance > 100000)
            {
                taxes = ((balance - 100000) * 0.03) + 50000 * 0.015;
            }
            
            balance -= taxes;
            taxesPaid += taxes;
        }


        balance = (int)balance;
        taxesPaid = (int)(taxesPaid);
        Console.WriteLine($"Balance after {years} years: {balance}");
        Console.WriteLine($"Amount of taxes paid: {taxesPaid}");
    }
}
