using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP1.Models;

namespace TP1.Pages;

public class Adicionar : PageModel
{
    [BindProperty]
    public Book Book { get; set; }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        return RedirectToPage("Index");
    }
}