using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;
using TP1.Models;
using TP1.Services;

namespace TP1.Pages;

public class Editar : PageModel
{
    private IBookService _service;
    private readonly IToastNotification _toastNotification;
    public Editar(IBookService bookService, IToastNotification toastNotification)
    {
        _service = bookService;
        _toastNotification = toastNotification;
    }
    
    [BindProperty]
    public Book Book { get; set; }

    public void OnGet(string id) => Book = _service.Get(id);

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        
        _service.Edit(Book);
        _toastNotification.AddSuccessToastMessage("Livro editado com sucesso.");
        return RedirectToPage("/Index");
    }

    public IActionResult OnPostDelete()
    {
        _service.Delete(Book.Id);
        _toastNotification.AddSuccessToastMessage("Livro deletado com sucesso.");
        return RedirectToPage("/Index");
    }
}