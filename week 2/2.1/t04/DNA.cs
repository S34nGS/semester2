public class DNA
{
    public string Seq;
    public DNA(string seq)
    {
        Seq = seq;
    }

    public DNA Replicate1()
    {
        DNA dna = new(Seq);
        return dna;
    }

    public DNA Replicate2()
    {
        return this;
    }

    public void Mutate(string newSeq)
    {
        Seq = newSeq;
    }
}