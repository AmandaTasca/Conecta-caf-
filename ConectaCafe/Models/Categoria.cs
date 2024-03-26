using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConectaCafe.Models;

[Table("Categoria")]
public class Categoria
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
     
     [Required(ErrorMessage = "Por Favor, Informe o nome ")]
     [StringLength(30, ErrorMessage = " O nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }
}
