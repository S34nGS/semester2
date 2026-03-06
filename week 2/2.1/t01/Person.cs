public class Person
{
    string Name;
    public Job DayJob;
    public Person(string name, Job dayJob)
    {
        Name = name;
        DayJob = dayJob;
    }

    public string Info()
    {
        if (DayJob != null)
        {
            return $"{Name} works as a {DayJob.Name}";
        }
        return $"{Name} is in between jobs";
    }
}