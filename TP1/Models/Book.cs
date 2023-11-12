using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace TP1.Models;

public class Book
{
    public int Id { get; set; }
    
    [Display(Name = "Título")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Título' obrigatório.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Título deve conter entre 3 e 50 caracteres.")]
    public string Name { get; set; }

    public string NameSlug => Name.ToLower().Replace(" ", "-");
    
    [Required(AllowEmptyStrings = false,ErrorMessage = "Campo 'Autor' obrigatório.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Autor deve conter entre 3 e 50 caracteres.")]
    [Display(Name = "Autor")]
    public string Author { get; set; }
    
    public string ImageUri { get; set; }
   
    [Display(Name = "Preço")]
    [Required(ErrorMessage = "Campo 'Preço' obrigatório.")]
    [DataType(DataType.Currency)]
    public double Price { get; set; }
    
    [Display(Name = "Entrega grátis")]
    public bool FreeDelivery { get; set; }
    public string FreeDeliveryDisplay => FreeDelivery ? "Sim" : "Não";
    
    [DisplayFormat(DataFormatString = "{0:D}")]
    [Required(ErrorMessage = "Campo 'Disponível em' obrigatório.")]
    [Display(Name = "Disponível desde")]
    public DateTime CreationDate { get; set; }
}