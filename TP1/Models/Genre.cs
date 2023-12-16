namespace TP1.Models;

public class Genre
{
    public List<Book> Books { get; } = new();

    public string GenreString { get; set; }
    public string GenreID { get; set; }
}