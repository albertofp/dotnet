using Microsoft.AspNetCore.Mvc.RazorPages;
using TP1.Models;

namespace TP1.Pages;

public class Adicionar : PageModel
{
    public Book Book { get; set; }

    public void OnGet()
    {
    }
}