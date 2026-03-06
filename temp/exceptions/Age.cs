public class Create
{
    // string Name;
    int Age;
    // public Create(int age)
    // {
    //     // Name = SetName(name);
    //     // Age = SetAge(age);
    // }

    public void SetAge(int value)
    {
        if (value <= 0 || value >= 200)
        {
            throw new ArgumentOutOfRangeException(nameof(Age), "Age should be between 0 and 200");
        }
        Age = value;

    }
}