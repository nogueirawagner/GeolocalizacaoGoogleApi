using GestaoDDD.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestaoDDD.MVC.ModelosPadronizados
{
  public class DepartamentoPoliciaAlunos
  {
    public IEnumerable<DepartamentoPoliciaViewModel> DepartamentosPolicia;
    public IEnumerable<DepartamentoPoliciaViewModel> DepartamentosPreferencia;

  }
}