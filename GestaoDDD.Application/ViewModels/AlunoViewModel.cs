using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestaoDDD.Application.ViewModels
{
  public class AlunoViewModel
  {
    public int ID { get; set; }

    public string Inscricao { get; set; }

    public string Nome { get; set; }
    public string Concorrencia { get; set; }
    public float NotaEtapa1 { get; set; }
    public float NotaEtapa2 { get; set; }
    public float NotaSAT { get; set; }
    public float NotaTIPDPP { get; set; }
    public int Posicao { get; set; }
  }
}