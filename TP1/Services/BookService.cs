using NToastNotify;
using shortid;
using TP1.Models;

namespace TP1.Services;

public class BookService : IBookService
{
    private IList<Book> _books;

    public BookService() => Seed();

    private void Seed()
    {
        _books = new List<Book>()
        {
           new()
            {
                Id = ShortId.Generate(), 
                Name = "To Kill a Mockingbird",
                Author = "Harper Lee",
                ImageUri = "/assets/covers/to_kill_a_mockingbird.jpg",
                Price = 18.00,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = ShortId.Generate(), 
                Name = "1984",
                Author = "George Orwell",
                ImageUri = "/assets/covers/1984.jpg",
                Price = 21.50,
                FreeDelivery = false,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = ShortId.Generate(), 
                Name = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                ImageUri = "/assets/covers/the_great_gatsby.jpg",
                Price = 24.99,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = ShortId.Generate(), 
                Name = "To the Lighthouse",
                Author = "Virginia Woolf",
                ImageUri = "/assets/covers/to_the_lighthouse.jpg",
                Price = 17.75,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = ShortId.Generate(), 
                Name = "The Catcher in the Rye",
                Author = "J.D. Salinger",
                ImageUri = "/assets/covers/the_catcher_in_the_rye.jpg",
                Price = 19.50,
                FreeDelivery = false,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = ShortId.Generate(), 
                Name = "The Hobbit",
                Author = "J.R.R. Tolkien",
                ImageUri = "/assets/covers/the_hobbit.jpg",
                Price = 29.00,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = ShortId.Generate(), 
                Name = "Pride and Prejudice",
                Author = "Jane Austen",
                ImageUri = "/assets/covers/pride_and_prejudice.jpg",
                Price = 23.99,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = ShortId.Generate(), 
                Name = "The Shining",
                Author = "Stephen King",
                ImageUri = "/assets/covers/the_shining.jpg",
                Price = 26.50,
                FreeDelivery = false,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = ShortId.Generate(), 
                Name = "Brave New World",
                Author = "Aldous Huxley",
                ImageUri = "/assets/covers/brave_new_world.jpg",
                Price = 22.99,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = ShortId.Generate(), 
                Name = "The Road",
                Author = "Cormac McCarthy",
                ImageUri = "/assets/covers/the_road.jpg",
                Price = 20.75,
                FreeDelivery = false,
                CreationDate = DateTime.Now
            } 
        };
    }

    public IList<Book> GetAll() => _books;

    public Book Get(string id)
    {
       return _books.SingleOrDefault(item => item.Id == id);
    }

    public void Create(Book book)
    {
        book.Id = ShortId.Generate();
        _books.Add(book);
    }

    public void Edit(Book book)
    {
        var selectedBook = Get(book.Id);
        selectedBook.Name = book.Name;
        selectedBook.Author = book.Author;
        selectedBook.FreeDelivery = book.FreeDelivery;
        selectedBook.Price = book.Price;
        selectedBook.ImageUri = book.ImageUri;
        selectedBook.CreationDate = book.CreationDate;
    }
}