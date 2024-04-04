using System;
using System.ComponentModel.DataAnnotations;

public class Comentario
{
    [Key]
    public int IDcomentario { get; set; }

    [Required]
    [StringLength(15)]
    public string IDfotografia { get; set; }

    [Required]
    [StringLength(30)]
    public string IDcliente { get; set; }

    [Required]
    public DateTime Fecha_comentario { get; set; }
}
