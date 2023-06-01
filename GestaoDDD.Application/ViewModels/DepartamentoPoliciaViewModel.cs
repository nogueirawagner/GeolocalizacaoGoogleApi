using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestaoDDD.Application.ViewModels
{
  public class DepartamentoPoliciaViewModel
  {
    [Key]
    public int ID { get; set; }
    public string EhSede { get; set; }
    public string Nome { get; set; }
    public string AreaAtuacao { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string Endereco { get; set; }
    public string Descricao { get; set; }
    public int Vagas { get; set; }
    public string Contemplada { get; set; }
    public string DistanciaColega { get; set; }
  }
}