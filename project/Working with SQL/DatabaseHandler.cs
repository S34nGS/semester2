using Microsoft.Data.Sqlite;

class DatabaseHandler
{
    private const string DatabaseLoc = "./books.db";

    // Example code
    public List<string> GetTitlesFromGenre(string genre)
    {
        // Write the SQL query
        string sql = "SELECT title FROM books WHERE genre = @Genre";

        // Set the connection
        using SqliteConnection connection = new($"Data Source={DatabaseLoc}");

        // Open the connection
        connection.Open();

        // Make new command object to execute our query in
        using SqliteCommand command = new(sql, connection);

        // Set parameters - values to replace in the query string
        command.Parameters.AddWithValue("@Genre", genre);

        // Execute the query
        SqliteDataReader result = command.ExecuteReader();

        // Handle the results
        // Read all rows and insert the title to the list
        List<string> titles = [];
        while (result.Read()) // while there is a next row to read
        {
            string? currentTitle = Convert.ToString(result["title"]); // Must be converted as the result has no type
            titles.Add(currentTitle!);
        }

        // Close the connectiom
        connection.Close();

        // return the list
        return titles;
    }

    public string? GetEmailWithID(int id)
    {
        string sql = "SELECT email FROM Accounts WHERE id = @Id";

        // Set the connection
        using SqliteConnection connection = new($"Data Source={DatabaseLoc}");

        // Open the connection
        connection.Open();

        // Make new command object to execute our query in
        using SqliteCommand command = new(sql, connection);

        // Set parameters - values to replace in the query string
        command.Parameters.AddWithValue("@Id", id);

        // Execute the query
        SqliteDataReader result = command.ExecuteReader();

        string? email = Convert.ToString(result["email"]);

        // Close the connectiom
        connection.Close();
        

        return email;
    }

    public List<string> GetBookTitlesFromAuthor(string author)
    {
        string sql = "SELECT * FROM books WHERE author = @Author";

        // Set the connection
        using SqliteConnection connection = new($"Data Source={DatabaseLoc}");

        // Open the connection
        connection.Open();

        // Make new command object to execute our query in
        using SqliteCommand command = new(sql, connection);

        command.Parameters.AddWithValue("@Author", author);

        // Execute the query
        SqliteDataReader result = command.ExecuteReader();

        List<string> titles = [];
        while (result.Read())
        {
            string? currentTitle = Convert.ToString(result["title"]);
            titles.Add(currentTitle!);
        }

        // Close the connectiom
        connection.Close();

        return titles;
    }

    public List<Book> GetAllBooks()
    {
        string sql = "SELECT * FROM Books";

        // Set the connection
        using SqliteConnection connection = new($"Data Source={DatabaseLoc}");

        // Open the connection
        connection.Open();

        // Make new command object to execute our query in
        using SqliteCommand command = new(sql, connection);

        // Execute the query
        SqliteDataReader result = command.ExecuteReader();

        List<Book> books = [];
        while (result.Read())
        {
            Book book = new(
                Convert.ToInt32(result["id"]),
                Convert.ToString(result["title"])!,
                Convert.ToString(result["genre"])!,
                Convert.ToString(result["author"])!
            );
            books.Add(book);
        }

        // Close the connectiom
        connection.Close();

        return books;
    }
}
