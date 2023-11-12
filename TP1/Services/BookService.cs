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
                ImageUri = "/assets/covers/to_kill_a_mockingbird.jpg",
                Price = 19.00,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 2,
                Name = "1984",
                Author = "George Orwell",
                ImageUri = "/assets/covers/1984.jpg",
                Price = 22.50,
                FreeDelivery = false,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 3,
                Name = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                ImageUri = "/assets/covers/the_great_gatsby.jpg",
                Price = 25.99,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 4,
                Name = "To the Lighthouse",
                Author = "Virginia Woolf",
                ImageUri = "/assets/covers/to_the_lighthouse.jpg",
                Price = 18.75,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 5,
                Name = "The Catcher in the Rye",
                Author = "J.D. Salinger",
                ImageUri = "/assets/covers/the_catcher_in_the_rye.jpg",
                Price = 20.50,
                FreeDelivery = false,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 6,
                Name = "The Hobbit",
                Author = "J.R.R. Tolkien",
                ImageUri = "/assets/covers/the_hobbit.jpg",
                Price = 30.00,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 7,
                Name = "Pride and Prejudice",
                Author = "Jane Austen",
                ImageUri = "/assets/covers/pride_and_prejudice.jpg",
                Price = 24.99,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 8,
                Name = "The Shining",
                Author = "Stephen King",
                ImageUri = "/assets/covers/the_shining.jpg",
                Price = 27.50,
                FreeDelivery = false,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 9,
                Name = "Brave New World",
                Author = "Aldous Huxley",
                ImageUri = "/assets/covers/brave_new_world.jpg",
                Price = 23.99,
                FreeDelivery = true,
                CreationDate = DateTime.Now
            },
            new()
            {
                Id = 10,
                Name = "The Road",
                Author = "Cormac McCarthy",
                ImageUri = "/assets/covers/the_road.jpg",
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