using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;
using TP1.Models;
using TP1.Services;

namespace TP1.Pages;

public class Adicionar : PageModel
{
    private IBookService _service;
    private readonly IToastNotification _toastNotification;
    public Adicionar(IBookService bookService, IToastNotification toastNotification)
    {
        _service = bookService;
        _toastNotification = toastNotification;
    }
    
    [BindProperty]
    public Book Book { get; set; }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        
        _service.Create(Book);
        _toastNotification.AddSuccessToastMessage("Livro adicionado com sucesso.");
        return RedirectToPage("/Index");
    }
}