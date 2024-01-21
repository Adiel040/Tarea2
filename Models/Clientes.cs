using System.ComponentModel.DataAnnotations;
//modelo de clientes
public class clientes
{
    [Key]
    public int ClienteId { get; set; }
    [Required(ErrorMessage = "El Nombre es obligatorio")]
    public string? Nombres { get; set; }
    [Required(ErrorMessage = "El Telefono es obligatorio")]
    public int Telefono { get; set; }
    [Required(ErrorMessage = "El Celular es obligatorio")]
    public int Celular { get; set; }
    [Required(ErrorMessage = "El RNC es obligatorio")]
    public string? Rnc { get; set; }
    [Required(ErrorMessage = "El Email es obligatorio")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "La Direccion es obligatoria")]
    public string? Direccion { get; set; }

    
}