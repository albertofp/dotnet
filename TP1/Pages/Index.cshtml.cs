using Microsoft.AspNetCore.Mvc.RazorPages;
using TP1.Models;
using TP1.Services;

namespace TP1.Pages;

public class IndexModel : PageModel
{
    public IList<Book> Books { get; private set; }

    public void OnGet()
    {
        ViewData["Title"] = "Home Page";

        var bookService = new BookService();
        Books = bookService.GetAll();
    }
}