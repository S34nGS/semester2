static class Program
{
    static void Main()
    {
        List<DNA> DNAList = [
            new("ACGT"),
            new("GCTTAC"),
            new("CGTTAGCTT"),
            new("TACA"),
        ];

        Console.WriteLine("What is the minimum sequence length?");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The filtered list:");
        foreach(DNA dna in DNAList)
        {
            if (dna.Seq.Length >= length)
            {
                Console.WriteLine($"{dna.Seq}");
            }
        }
    }
}
