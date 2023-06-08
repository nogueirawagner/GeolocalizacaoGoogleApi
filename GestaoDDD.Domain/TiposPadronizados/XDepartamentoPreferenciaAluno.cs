using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDDD.Domain.TiposPadronizados
{
  public class XDepartamentoPreferenciaAluno
  {
    public string Nome { get; set; }
    public int DepartamentoId { get; set; }
    public int AlunoId { get; set; }
    public int QtdVagas { get; set; }
    public string Contemplada { get; set; }
  }
}
