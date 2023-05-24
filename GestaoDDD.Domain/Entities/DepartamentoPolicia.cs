using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDDD.Domain.Entities
{
  public class DepartamentoPolicia
  {
    public int ID { get; set; }
    public bool EhSede { get; set; }
    public string Nome { get; set; }
    public string AreaAtuacao { get; set; }
    public string Endereco { get; set; }
    public string Descricao { get; set; }
    public int Vagas { get; set; }
  }
}
