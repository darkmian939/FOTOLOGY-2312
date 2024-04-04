using System.ComponentModel.DataAnnotations;

public class Fotografia
{
    [Key]
    [StringLength(15)]
    public string IDfotografia { get; set; }

    [Required]
    [StringLength(50)]
    public string Titulo { get; set; }

    [Required]
    public string Descripcion { get; set; }

    [Required]
    [StringLength(15)]
    public string IDcategoria { get; set; }

    [Required]
    public int IDfotografo { get; set; }

    [Required]
    public int IDcalificacion { get; set; }
}
