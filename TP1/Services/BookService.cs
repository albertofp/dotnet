using TP1.Models;

namespace TP1.Services;

public class BookService
{
    public IList<Book> GetAll()
    {
        return new List<Book>
        {
            new()
            {
                Id = 1,
                Name = "To Kill a Mockingbird",
                Author = "Harper Lee",
                ImageUri = "https://images-na.ssl-images-amazon.com/images/I/81r3FVzGxPL.jpg",
                Price = 19.00,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 2,
                Name = "1984",
                Author = "George Orwell",
                ImageUri = "https://images-na.ssl-images-amazon.com/images/I/81l8e48eygL.jpg",
                Price = 22.50,
                FreeDelivery = false,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 3,
                Name = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                ImageUri = "https://images-na.ssl-images-amazon.com/images/I/71sWLOcdIvL.jpg",
                Price = 25.99,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 4,
                Name = "To the Lighthouse",
                Author = "Virginia Woolf",
                ImageUri = "https://images-na.ssl-images-amazon.com/images/I/81Sz9bIn3kL.jpg",
                Price = 18.75,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 5,
                Name = "The Catcher in the Rye",
                Author = "J.D. Salinger",
                ImageUri = "https://images-na.ssl-images-amazon.com/images/I/81h2gWPTYJL.jpg",
                Price = 20.50,
                FreeDelivery = false,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 6,
                Name = "The Hobbit",
                Author = "J.R.R. Tolkien",
                ImageUri = "https://images-na.ssl-images-amazon.com/images/I/91n6KmXMTYL.jpg",
                Price = 30.00,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 7,
                Name = "Pride and Prejudice",
                Author = "Jane Austen",
                ImageUri = "https://images-na.ssl-images-amazon.com/images/I/71BHh9fROXL.jpg",
                Price = 24.99,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 8,
                Name = "The Shining",
                Author = "Stephen King",
                ImageUri = "https://images-na.ssl-images-amazon.com/images/I/81Gwpz8-7lL.jpg",
                Price = 27.50,
                FreeDelivery = false,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 9,
                Name = "Brave New World",
                Author = "Aldous Huxley",
                ImageUri = "https://images-na.ssl-images-amazon.com/images/I/81+j0JdJt-L.jpg",
                Price = 23.99,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 10,
                Name = "The Road",
                Author = "Cormac McCarthy",
                ImageUri = "https://images-na.ssl-images-amazon.com/images/I/81b-MvG-9-L.jpg",
                Price = 21.75,
                FreeDelivery = false,
                CreationDate = DateTime.Now
            }
        };
    }

    public Book Get(int id)
    {
       return GetAll()?.SingleOrDefault(item => item.Id == id)!;
    }
}