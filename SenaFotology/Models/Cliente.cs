using System.ComponentModel.DataAnnotations;

public class Cliente
{
    [Key]
    [StringLength(30)]
    public string IDcliente { get; set; }

    [Required]
    [StringLength(50)]
    public string Nombre_cliente { get; set; }

    [Required]
    [StringLength(50)]
    public string Email { get; set; }

    [Required]
    [StringLength(20)]
    public string Contrasena { get; set; }

    public long Telefono { get; set; }
}
