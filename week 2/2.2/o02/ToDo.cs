public class ToDo
{
    List<Task> TaskList = [];

    public void AddTask(string name)
    {
        TaskList.Add(new(name));
    }

    public Task? GetTask(string name)
    {
        foreach(Task task in TaskList)
        {
            if (name == task.Name)
            {
                return task;
            }
        }
        return null;
    }

    public string Report()
    {
        string report = "";
        foreach(Task task in TaskList)
        {
            report += $"{task.Info()}\n";
        }
        return report;
    }
}