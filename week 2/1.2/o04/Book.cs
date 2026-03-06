public class Book
{
    public int Id;
    public string Title;
    public Book(int id, string title)
    {
        Id = id;
        Title = title;
    }

    public string GetInfo()
    {
        return $"ID: {Id}, Title: {Title}";
    }
}