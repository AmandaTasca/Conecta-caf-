using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConectaCafe.Models;

[Table("Produto")]
public class Produto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
     
     [Required(ErrorMessage = "Por Favor, Informe o nome ")]
     [StringLength(60, ErrorMessage = " O nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

      [Display(Name = "Descriçâo")]
      [StringLength(200, ErrorMessage = " A descrição deve possuir no máximo 200 caracteres")]
    public string Descricao { get; set; }

    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(8,2)")]
    [Required(ErrorMessage = "Por Favor, Informe o preço ")]
    public decimal Preco { get; set; }

    [StringLength(200)]
    public string Foto { get; set; }

    [Display(Name = "Categoria")]
    [Required(ErrorMessage = "Por favor informe a a categoria")]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]

    public Categoria Categoria { get; set; }
}
