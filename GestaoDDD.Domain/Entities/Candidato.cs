using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestaoDDD.Domain.Entities
{
  public class Candidato
  {
    public int ID { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string TipoVeiculo { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string Endereco { get; set; }
    public string Descricao { get; set; }
    public string QtdVagasCarro { get; set; }
    public string Turma { get; set; }
    public double Valor { get; set; }
    public int QtdVagasDisponivelCasa { get; set; }
    [NotMapped]
    public string DistanciaColega { get; set; }
    [NotMapped]
    public string DistanciaEscolas { get; set; }
    
  }
}
