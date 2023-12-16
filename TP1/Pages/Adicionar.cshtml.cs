using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using TP1.Models;
using TP1.Services;

namespace TP1.Pages;

[Authorize]
public class Adicionar : PageModel
{
    private IBookService _service;
    private readonly IToastNotification _toastNotification;

    public Adicionar(IBookService bookService, IToastNotification toastNotification)
    {
        _service = bookService;
        _toastNotification = toastNotification;
    }

    [BindProperty] public Book Book { get; set; }

    public List<SelectListItem> Genres { get; set; }

    public IActionResult OnGet()
    {
        var genresFromService = _service.GetGenres();

        // Map genres to SelectListItems for the dropdown
        Genres = new List<SelectListItem>
        {
            new("Select Genre", "") // Optional: add a default option
        };

        foreach (var genre in genresFromService) Genres.Add(new SelectListItem(genre.GenreString, genre.GenreID));

        return Page();
    }

    public IActionResult OnPost()
    {
        _service.Create(Book);
        _toastNotification.AddSuccessToastMessage("Livro adicionado com sucesso.");
        return RedirectToPage("/Index");
    }
}