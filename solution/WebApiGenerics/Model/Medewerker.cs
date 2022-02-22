using System.ComponentModel.DataAnnotations;

namespace WebApiDefault.Model;

public class Medewerker
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Naam { get; set; }
}