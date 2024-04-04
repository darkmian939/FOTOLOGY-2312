using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Fotografo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IDfotografo { get; set; }

    [Required]
    [StringLength(50)]
    public string Nombre_fotografo { get; set; }

    [Required]
    [StringLength(255)]
    public string Foto_de_perfil { get; set; }

    [Required]
    public string Descripcion { get; set; }

    [Required]
    [StringLength(30)]
    public string Email { get; set; }

    [Required]
    [StringLength(20)]
    public string Contrasena { get; set; }

    [Required]
    [StringLength(50)]
    public string Direccion { get; set; }

    [Required]
    [StringLength(30)]
    public string Telefono { get; set; }

    [Required]
    [StringLength(50)]
    public string Portafolio { get; set; }
}
