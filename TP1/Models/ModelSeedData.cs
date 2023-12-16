using Microsoft.EntityFrameworkCore;

namespace TP1.Models;

public class ModelSeedData
{
    public static void SeedGenres(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
            new Genre { GenreID = "1", GenreString = "Ficção Científica" },
            new Genre { GenreID = "2", GenreString = "Fantasia" },
            new Genre { GenreID = "3", GenreString = "Mistério" },
            new Genre { GenreID = "4", GenreString = "Suspense" },
            new Genre { GenreID = "5", GenreString = "Romance" },
            new Genre { GenreID = "6", GenreString = "Ficção Histórica" },
            new Genre { GenreID = "7", GenreString = "Aventura" },
            new Genre { GenreID = "8", GenreString = "Terror" },
            new Genre { GenreID = "9", GenreString = "Não Ficção" },
            new Genre { GenreID = "10", GenreString = "Biografia" }
        );
    }

    public static void SeedBooks(ModelBuilder modelBuilder)
    {
        if (!modelBuilder.Entity<Book>().HasData())
        {
                modelBuilder.Entity<Book>().HasData(
                    new Book
                    {
                        Id = "3",
                        Name = "The Great Gatsby",
                        Author = "F. Scott Fitzgerald",
                        ImageUri = "/assets/covers/the_great_gatsby.jpg",
                        Price = 24.99,
                        FreeDelivery = true,
                        CreationDate = new DateTime(2023, 12, 01),
                        GenreID = "5" // Romance
                    },
                    new Book
                    {
                        Id = "4",
                        Name = "To the Lighthouse",
                        Author = "Virginia Woolf",
                        ImageUri = "/assets/covers/to_the_lighthouse.jpg",
                        Price = 17.75,
                        FreeDelivery = true,
                        CreationDate = new DateTime(2023, 12, 01),
                        GenreID = "6" // Ficção Histórica
                    },
                    new Book
                    {
                        Id = "5",
                        Name = "The Catcher in the Rye",
                        Author = "J.D. Salinger",
                        ImageUri = "/assets/covers/the_catcher_in_the_rye.jpg",
                        Price = 19.50,
                        FreeDelivery = false,
                        CreationDate = new DateTime(2023, 12, 01),
                        GenreID = "5" // Romance
                    },
                    new Book
                    {
                        Id = "6",
                        Name = "The Hobbit",
                        Author = "J.R.R. Tolkien",
                        ImageUri = "/assets/covers/the_hobbit.jpg",
                        Price = 29.00,
                        FreeDelivery = true,
                        CreationDate = new DateTime(2023, 12, 01),
                        GenreID = "2" // Fantasia
                    },
                    new Book
                    {
                        Id = "7",
                        Name = "Pride and Prejudice",
                        Author = "Jane Austen",
                        ImageUri = "/assets/covers/pride_and_prejudice.jpg",
                        Price = 23.99,
                        FreeDelivery = true,
                        CreationDate = new DateTime(2023, 12, 01),
                        GenreID = "5" // Romance
                    },
                    new Book
                    {
                        Id = "8",
                        Name = "The Shining",
                        Author = "Stephen King",
                        ImageUri = "/assets/covers/the_shining.jpg",
                        Price = 26.50,
                        FreeDelivery = false,
                        CreationDate = new DateTime(2023, 12, 01),
                        GenreID = "8" // Terror
                    },
                    new Book
                    {
                        Id = "9",
                        Name = "Brave New World",
                        Author = "Aldous Huxley",
                        ImageUri = "/assets/covers/brave_new_world.jpg",
                        Price = 22.99,
                        FreeDelivery = true,
                        CreationDate = new DateTime(2023, 12, 01),
                        GenreID = "1" // Ficção Científica
                    },
                    new Book
                    {
                        Id = "10",
                        Name = "The Road",
                        Author = "Cormac McCarthy",
                        ImageUri = "/assets/covers/the_road.jpg",
                        Price = 20.75,
                        FreeDelivery = false,
                        CreationDate = new DateTime(2023, 12, 01),
                        GenreID = "4" // Suspense
                    }
                );
        }
    }
}