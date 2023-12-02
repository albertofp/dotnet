using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TP1.Models;

public class Book
{
    public string Id { get; set; }

    [Display(Name = "Título")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Título' obrigatório.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Título deve conter entre 3 e 50 caracteres.")]
    public string Name { get; set; }

    public string NameSlug => Name.ToLower().Replace(" ", "-");

    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Autor' obrigatório.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Autor deve conter entre 3 e 50 caracteres.")]
    [Display(Name = "Autor")]
    public string Author { get; set; }

    [Required(ErrorMessage = "Campo 'Link Capa' obrigatório.")]
    [Display(Name = "Link Capa")]
    public string ImageUri { get; set; }

    [Display(Name = "Preço")]
    [Required(ErrorMessage = "Campo 'Preço' obrigatório.")]
    [DataType(DataType.Currency)]
    public double Price { get; set; }

    [Display(Name = "Entrega grátis")] public bool FreeDelivery { get; set; }
    public string FreeDeliveryDisplay => FreeDelivery ? "Sim" : "Não";

    [DisplayFormat(DataFormatString = "{0:MMMM \\de yyyy}")]
    [Required(ErrorMessage = "Campo 'Disponível em' obrigatório.")]
    [DataType("month", ErrorMessage = "Obrigatório")]
    [Display(Name = "Disponível em")]
    public DateTime CreationDate { get; set; }

    public string GenreID { get; set; }
    public Genre Genre { get; set; }
}

public class BooksContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public string DbPath { get; }

    public BooksContext(DbContextOptions<BooksContext> options) : base(options)
    {
        DbPath = "books.db";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={DbPath}");
    }
}

public class Genre
{
    public List<Book> Books { get; } = new();

    public string GenreString { get; set; }
    public string GenreID { get; set; }
}