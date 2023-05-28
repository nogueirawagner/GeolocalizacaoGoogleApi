using AutoMapper;
using GestaoDDD.Application.ViewModels;
using GestaoDDD.Domain.Entities;

namespace GestaoDDD.MVC.AutoMapper
{
  public class ViewModelToDomainMappingProfile : Profile
  {
    protected override void Configure()
    {
      //mapeia classe para categoria
      Mapper.CreateMap<Candidato, CandidatoViewModel>();
      Mapper.CreateMap<DepartamentoPolicia, DepartamentoPoliciaViewModel>();
      Mapper.CreateMap<Aluno, AlunoViewModel>();
    }
  }
}