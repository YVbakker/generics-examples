using System.ComponentModel.DataAnnotations;

namespace WebApiDefault.Model;

public class Auto
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Kenteken { get; set; }
    public bool IsOldtimer { get; set;  }
}