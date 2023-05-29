using AutoMapper;
using GeoCoordinatePortable;
using GestaoDDD.Application.Interface;
using GestaoDDD.Application.ViewModels;
using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace GestaoDDD.Application.Services
{
  public class DptoAlunoAppService : AppServiceBase<DepartamentoAluno>, IDptoAlunoAppService
  {
    private readonly IDptoAlunoService _dptoAlunoService;

    public DptoAlunoAppService(IDptoAlunoService dptoAlunoService)
        : base(dptoAlunoService)
    {
      _dptoAlunoService = dptoAlunoService;
    }
  }
}
