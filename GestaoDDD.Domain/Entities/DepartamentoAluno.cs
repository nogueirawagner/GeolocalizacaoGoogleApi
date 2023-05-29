using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDDD.Domain.Entities
{
  public class DepartamentoAluno
  {
    public int ID { get; set; }

    public int AlunoID { get; set; }

    public int DptoID { get; set; }
  }
}
