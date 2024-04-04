using System.ComponentModel.DataAnnotations;

public class Categorias
{
    [Key]
    [StringLength(20)]
    public string IDcategoria { get; set; }

    [Required]
    [StringLength(20)]
    public string Nombre { get; set; }

    [Required]
    public string Descripcion { get; set; }

    [Required]
    [StringLength(15)]
    public string IDportafolio { get; set; }
}
