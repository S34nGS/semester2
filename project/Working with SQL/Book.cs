// Do not modify this file

class Book
{
    public int ID;
    public string Title;
    public string Genre;
    public string Author;

    public Book(int id, string title, string genre, string author)
    {
        ID = id;
        Title = title;
        Genre = genre;
        Author = author;
    }

    public override string ToString()
    {
        return $"Book {ID} {Title}, {Genre}, written by {Author}";
    }
}
