using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConectaCafe.Models;

[Table("Blog")]
public class Blog
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
     
     [Required(ErrorMessage = "Por Favor, Informe o titulo")]
     [StringLength(100, ErrorMessage = " O titulo deve possuir no máximo 100 caracteres")]
    public string Titulo { get; set; }

     [Required(ErrorMessage = "Por Favor, Informe o Texto ")]
     [StringLength(500, ErrorMessage = " O titulo deve possuir no máximo 500 caracteres")]
    public string Texto { get; set; }

    [StringLength(200)]
    public string Foto { get; set; }

   [Display(Name = "Data de Cadastro")]
    public DateTime DataBlog { get; set; }
}
