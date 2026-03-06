// Do not modify this file

class Book
{
    public Int64 ID { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public string Author { get; set; }

    public Book(Int64 id, string title, string genre, string author)
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
