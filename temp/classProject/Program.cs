public class Program
{
    public static void Main()
    {
        Person sean = new("Sean", "Steenhuis");
        Person damian = new("Damian", "Vaartmans");
        Person john = new("John", "Doe");

        List<Person> employees = [];

        Company bol = new("bol", sean, employees);
        bol.Hire(sean);
        bol.Hire(damian);
        bol.Hire(john);


        Console.WriteLine(bol.GetInfo());
    }
}