public static class PersonFactory
{
    public static int GenerateRandomAge()
    {
        Random r = new();
        return r.Next(Person.MaxAge + 1);
    }
    public static Person CreateJohn()
    {
        return new Person("John Doe", GenerateRandomAge());
    }

    public static Person CreateJane()
    {
        return new Person("Jane Doe", GenerateRandomAge());
    }
}