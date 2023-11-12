using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace TP1.Models;

public class Book
{
    public int Id { get; set; }
    
    [Display(Name = "Nome")]
    public string Name { get; set; } 
    
    [Display(Name = "Autor")]
    public string Author { get; set; }
    
    public string ImageUri { get; set; }
   
    [Display(Name = "Preço")]
    [DataType(DataType.Currency)]
    public double Price { get; set; }
    
    [Display(Name = "Entrega grátis")]
    public bool FreeDelivery { get; set; }
    public string FreeDeliveryDisplay => FreeDelivery ? "Sim" : "Não";
    
    [DisplayFormat(DataFormatString = "{0:D}")]
    [Display(Name = "Disponível desde")]
    public DateTime CreationDate { get; set; }
}