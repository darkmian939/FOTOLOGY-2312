using System.ComponentModel.DataAnnotations;

public class Portafolio
{
    [Key]
    [StringLength(15)]
    public required string IDportafolio { get; set; }

    [Required]
    public int IDfotografo { get; set; }

    [Required]
    [StringLength(30)]
    public required string Nombre_portafolio { get; set; }
}
