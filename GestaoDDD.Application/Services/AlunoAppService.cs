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
  public class AlunoAppService : AppServiceBase<Aluno>, IAlunoAppService
  {
    private readonly IAlunoService _alunoService;

    public AlunoAppService(IAlunoService alunoService)
        : base(alunoService)
    {
      _alunoService = alunoService;
    }

  }
}
