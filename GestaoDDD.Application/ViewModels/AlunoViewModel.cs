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
    public double NotaEtapa1 { get; set; }
    public double NotaEtapa2 { get; set; }
    public double NotaFinal { get; set; }
    public double NotaFinalProvisoria { get; set; }

    public int Posicao { get; set; }
    public int PosicaoProvisoria { get; set; }
    public string Cargo { get; set; }
  }
}