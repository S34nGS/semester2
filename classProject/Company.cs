public class Company
{
    public string Name;
    public Person Manager;
    public List<Person> Employees = [];

    public Company(string name, Person manager, List<Person> employees)
    {
        Name = name;
        Manager = manager;
        Employees = employees;
    }

    public string GetInfo()
    {
        string manager = Manager == null? "None" : Manager.GetName();
        return $"Company Name: {Name}\nManager: {manager}\n {GetEmployeeInfo()}";
    }

    public string GetEmployeeInfo()
    {
        string info = "Employees: ";
        foreach (var employee in Employees)
        {
            info+=employee.GetName() + ", ";
        }
        return info;
    }

    public Person GetManager()
    {
        return Manager;
    }

    public void SetManager(Person manager)
    {
        Manager = manager;
    }

    public void Hire(Person employee)
    {
        if(employee != null)
        {        
           Employees.Add(employee);
        }
    }

    public void BulkHire(List<Person> people)
    {
        foreach (var person in people)
        {
            Hire(person);
        }
    }
}