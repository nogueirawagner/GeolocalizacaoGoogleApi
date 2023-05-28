

using AutoMapper;
using GestaoDDD.Application.ViewModels;
using GestaoDDD.Domain.Entities;

namespace GestaoDDD.MVC.AutoMapper
{
  public class DomainToViewModelMappingProfile : Profile
  {
    protected override void Configure()
    {
      //mapeia de viewModel para classe
      Mapper.CreateMap<CandidatoViewModel, Candidato>();
      Mapper.CreateMap<DepartamentoPoliciaViewModel, DepartamentoPolicia>();
      Mapper.CreateMap<AlunoViewModel, Aluno>();
    }
  }
}