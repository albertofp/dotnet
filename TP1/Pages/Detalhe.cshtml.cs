using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP1.Models;
using TP1.Services;

namespace TP1.Pages;

public class Detalhe : PageModel
{
    private IBookService _service;

    public Detalhe(IBookService bookService)
    {
        _service = bookService;
    }
    public Book? Book { get; set; }

    public IActionResult OnGet(string id)
    {
        Book = _service.Get(id);

        if (Book == null)
        {
            return NotFound();
        }
        return Page();
    }
}