class Person
{
    string FirstName;
    string LastName;

    public Person(string fName, string lName){
        FirstName = fName;
        LastName = lName;
    }
    public string GetIntroduction() => $"I am {FirstName} {LastName}";
}
