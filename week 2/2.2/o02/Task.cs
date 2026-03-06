public class Task
{
    public string Name;
    bool IsDone;

    public Task(string name)
    {
        Name = name;
    }

    public void Done()
    {
        IsDone = true;
    }

    public string Info()
    {
        string status = IsDone ? "Done" : "Pending";
        return $"Task: {Name}, Status: {status}";
    }
}