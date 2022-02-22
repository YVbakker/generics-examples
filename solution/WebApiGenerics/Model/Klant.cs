using System.ComponentModel.DataAnnotations;

namespace WebApiGenerics.Model;

public class Klant
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Naam { get; set; }
    public int Leeftijd { get; set; }
}