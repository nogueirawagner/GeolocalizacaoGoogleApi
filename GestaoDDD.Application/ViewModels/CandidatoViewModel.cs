using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestaoDDD.Application.ViewModels
{
  public class CandidatoViewModel
  {
    [Key]
    public int ID { get; set; }

    [Required(ErrorMessage = "Preencha seu nome")]
    [MaxLength(100, ErrorMessage = "Tamanho máximo de {0} caracteres.")]
    [MinLength(3, ErrorMessage = "Tamanho minímo de {0} caracteres.")]
    [DisplayName("Nome:")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Preencha com o seu WhatsApp")]
    [StringLength(14, ErrorMessage = "A {0} deve conter {1} caracteres ao menos.", MinimumLength = 11)]
    [DataType(DataType.PhoneNumber)]
    public string Telefone { get; set; }

    public string TipoVeiculo { get; set; }


    [Required(ErrorMessage = "Preencha o endereço que ficará hospedado.")]
    [MaxLength(200, ErrorMessage = "Tamanho máximo de {0} caracteres.")]
    [MinLength(5, ErrorMessage = "Tamanho minímo de {0} caracteres.")]
    [DisplayName("Endereço:")]
    public string Endereco { get; set; }

    public string Turma { get; set; }

    public string Latitude { get; set; }
    public string Longitude { get; set; }
  }
}