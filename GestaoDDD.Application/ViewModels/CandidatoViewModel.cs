using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestaoDDD.Application.ViewModels
{
  public class CandidatoViewModel
  {
    [Key]
    public int ID { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string TipoVeiculo { get; set; }
    public string Endereco { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
  }
}