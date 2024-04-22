using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConectaCafe.Models;

[Table("Avaliação")]
public class Avaliacao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

   
     [Required(ErrorMessage = "Por favor, Informe o nome da pessoa.")]
     [StringLength(60, ErrorMessage = " O nome deve possuir no máximo 60 caracteres")]
    public string Pessoa { get; set; }
        

    [Required(ErrorMessage = "Por favor, Informe o texto. ")]
     [StringLength(500, ErrorMessage = "O texto deve possuir no máximo 500 caracteres")]
    public string Texto { get; set; }

    
    [Column(TypeName = "decimal(1,0)")]
    [Required(ErrorMessage = "Por favor, Informe o preço. ")]
    public decimal Nota { get; set; } = 5;


    [Display( Name ="Data da Avaliação")]
    [DataType(DataType.Date)]
    public DateTime DataAvaliacao { get; set; } = DateTime.Now;


     [StringLength(200)]
    public string Foto { get; set; }
}
