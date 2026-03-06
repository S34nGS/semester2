public class Person
{
    string firstName;
    string lastName;

    public Person(string fName, string lName){
        firstName = fName;
        lastName = lName;
    }

    public string GetName()
    {
        return $"{firstName[0]}. {lastName}";
    }
}