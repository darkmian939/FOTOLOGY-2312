using System.ComponentModel.DataAnnotations;

public class Calificacion
{
    [Key]
    public int IDcalificacion { get; set; }

    [Required]
    public int ValorCalificacion { get; set; } // Cambio de nombre

    [Required]
    [StringLength(15)]
    public required string IDfotografia { get; set; }
}
