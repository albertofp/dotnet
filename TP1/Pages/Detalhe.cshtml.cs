using Microsoft.AspNetCore.Mvc.RazorPages;
using TP1.Models;
using TP1.Services;

namespace TP1.Pages;

public class Detalhe : PageModel
{  
    public Book Book { get; set; }
    public void OnGet(int id)
    {
        var bookService = new BookService();
        Book = bookService.Get(id);
    }
}