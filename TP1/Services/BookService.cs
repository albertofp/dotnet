using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shortid;
using TP1.Models;

namespace TP1.Services;

public class BookService : IBookService
{
    private readonly BooksContext _context;

    public BookService(BooksContext context) => _context = context;
    
    public IList<Book> GetAll() => _context.Books.Include(b => b.Genre).ToList();

    public Book Get(string id) => _context.Books.Include(b => b.Genre).FirstOrDefault(b => b.Id == id);


    public void Create(Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
    }

    public void Edit(Book book)
    {
        var existingBook = _context.Books.Find(book.Id);
        if (existingBook == null) return;
        
        existingBook.Name = book.Name;
        existingBook.Author = book.Author;
        existingBook.FreeDelivery = book.FreeDelivery;
        existingBook.Price = book.Price;
        existingBook.ImageUri = book.ImageUri;
        existingBook.CreationDate = book.CreationDate;
        existingBook.GenreID = book.GenreID;

        _context.SaveChanges();
    }

    public void Delete(string id)
    {
        var bookToDelete = _context.Books.Find(id);
        if (bookToDelete == null) return;
        
        _context.Books.Remove(bookToDelete);
        _context.SaveChanges();
    }

    public IList<Genre> GetGenres() => _context.Genres.ToList();
    
    public Genre GetGenreById(string genreId) => _context.Genres.FirstOrDefault(g => g.GenreID == genreId) ?? throw new InvalidOperationException();
}