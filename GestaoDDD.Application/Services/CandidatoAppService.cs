using GestaoDDD.Application.Interface;
using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Services;

namespace GestaoDDD.Application.Services
{
  public class CandidatoAppService : AppServiceBase<Candidato>, ICandidatoAppService
  {
    private readonly ICandidatoService _candidatoService;

    public CandidatoAppService(ICandidatoService candidatoService)
        : base(candidatoService)
    {
      _candidatoService = candidatoService;
    }

    /*
       public IEnumerable<Orcamento> RetornarOrcamentosComDistanciaCalculada(string prestadorLatitude,
        string prestadorLongitude, string raio, string usuarioId)
    {
      var orcamentos = _orcamentoService.RetornaOrcamentosAbertos().ToList();
      var orcamentosPagos = GetOrcamentoPagosPeloPrestador(usuarioId).ToList();

      var orcamentosView = new List<Orcamento>();
      foreach (var orcamento in orcamentos)
      {


        var expirou = _orcamentoService.PegarQuantidadeOrcamentosPorPrestador(orcamento.orc_Id);
        if (!expirou)
          continue;

        if (orcamentosPagos.All(s => s.orc_Id != orcamento.orc_Id))
        {
          var coord_orcamento = new GeoCoordinate();
          coord_orcamento.Latitude = double.Parse(orcamento.orc_latitude.Replace(",", "."),
              CultureInfo.InvariantCulture);
          coord_orcamento.Longitude = double.Parse(orcamento.orc_longitude.Replace(",", "."),
              CultureInfo.InvariantCulture);

          var coordenada_prestador = new GeoCoordinate();
          coordenada_prestador.Latitude = double.Parse(prestadorLatitude.Replace(",", "."),
              CultureInfo.InvariantCulture);
          coordenada_prestador.Longitude = double.Parse(prestadorLongitude.Replace(",", "."),
              CultureInfo.InvariantCulture);

          var distancia = (coordenada_prestador.GetDistanceTo(coord_orcamento) / 1000);

          var endereco = orcamento.orc_endereco;
          var cidade = "";
          var estado = new EnumAppEstados();
          var partes = endereco.Split(',');
          foreach (var parte in partes.Where(s => s.Contains("-")))
          {

            var separar = parte.Split('-');
            var ufs = " AC, AL, AP, AM, BA, CE, DF, ES, GO, MA, MT, MS, MG, PA,PB, PR, PE, PI, RJ, RN, RS, RO, RR, SC, SP, SE, TO";
            if (ufs.Contains(separar[1]))
            {
              estado = (EnumAppEstados)Enum.Parse(typeof(EnumAppEstados), separar[1]);
              cidade = separar[0];
            }
            else
              continue;
          }

          orcamento.Distancia = Math.Round(distancia, 2).ToString() + " Km do seu negócio em " +
                                cidade.ToString().Trim() +
                                " - " + estado.ToString().Trim() + " ";

          if (distancia <= double.Parse(raio))
            orcamentosView.Add(orcamento);
        }
      }
      return orcamentosView;
    }
     
     */

    //public IEnumerable<Candidato> ObterCandidatosEspeciais()
    //{
    //    return Mapper.Map<IEnumerable<Candidato>, IEnumerable<CandidatoViewModel>>(_candidatoService.ObterCandidatosEspeciais());
    //}
  }
}
