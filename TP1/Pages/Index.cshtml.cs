using Microsoft.AspNetCore.Mvc.RazorPages;
using TP1.Models;
using TP1.Services;

namespace TP1.Pages;

public class IndexModel : PageModel
{
    private IBookService _service;
    public IndexModel(IBookService bookService)
    {
        _service = bookService;
    }
    
    public IList<Book>? Books { get; private set; }

    public void OnGet()
    {
        ViewData["Title"] = "Home Page";
        Books = _service.GetAll();
    }
}