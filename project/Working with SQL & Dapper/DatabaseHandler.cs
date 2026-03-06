using Dapper;
using Microsoft.Data.Sqlite;

class DatabaseHandler
{
    public const string DatabaseLoc = "./books.db";

    // example code
    public List<string> GetTitlesFromGenre(string genre)
    {
        string sql = "SELECT title FROM books WHERE genre = @Genre";
        SqliteConnection connection = new($"Data Source={DatabaseLoc}");

        // Dapper will handle a lot of code for us in the background.
        // As you can see from the previous SQL exercise, this new Dapper code is much smaller.

        // Execute a query, give a generic of the type we expect as answer from the query.
        // Set the parameters as a anonymous object, Genre matches the @Genre in the sql string.
        // Parse the strings from the result into a list.
        List<string> titles = connection.Query<string>(sql, new { Genre = genre }).ToList();

        // Return the list
        return titles;
    }

    // This is where Dapper can do magic. It can create Book objects from the results automatically.
    // If the names of the properties in the Book object match the names of the columns in the Book table in the database.
    // It will try to use the Book class constructor to pass the results from the query to Book objects.
    public List<Book> GetAllBooks()
    {
        // Write the SQL query
        string sql = "SELECT * FROM books";
        SqliteConnection connection = new($"Data Source={DatabaseLoc}");

        List<Book> books = connection.Query<Book>(sql).ToList();

        // return the list
        return books;
    }

    public List<Book> GetBooksFromAuthor(string author)
    {
        string sql = "SELECT * FROM books WHERE author = @Author";
        SqliteConnection connection = new($"Data Source={DatabaseLoc}");
        List<Book> books = connection.Query<Book>(sql, new { Author = author }).ToList();

        return books;
    }

    public Account GetAccountById(Int64 id)
    {
        string sql = "SELECT * FROM accounts WHERE id = @Id";
        SqliteConnection connection = new($"Data Source={DatabaseLoc}");
        Account account = connection.QuerySingle<Account>(sql, new { Id = id });
        return account;
    }

    // Dapper can also do the reverse.
    // Set the fields of an Object as parameters.
    // This only works if the property names in your object match the SQL parameters.
    public bool UpdateAccount(Account account)
    {
        // Example code
        string sql = "UPDATE accounts SET email = @Email, fullname = @FullName WHERE id = @ID";
        SqliteConnection connection = new($"Data Source={DatabaseLoc}");

        int rowsAffected = connection.Execute(sql, account);

        return rowsAffected >= 1;
    }

    public bool UpdateBook(Book book)
    {
        string sql = "UPDATE books SET title = @Title, genre = @Genre, author = @author WHERE id = @Id";
        SqliteConnection connection = new($"Data Source={DatabaseLoc}");
        int rowsAffected = connection.Execute(sql, book);
        return rowsAffected >= 1;
    }
}
