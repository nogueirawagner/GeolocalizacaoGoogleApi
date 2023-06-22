using System.Data.Entity;
using GestaoDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using GestaoDDD.Infra.Data.EntityConfig;

namespace GestaoDDD.Infra.Data.Contexto
{
  public class GestaoContext : DbContext, IGestaoContext
  {
    public GestaoContext()
        : base(PegarDatabase())
    {
      Configuration.ProxyCreationEnabled = false;
      Configuration.LazyLoadingEnabled = true;
    }

    #region objetos
    public DbSet<Candidato> Candidato { get; set; }
    public DbSet<DepartamentoPolicia> DepartamentoPolicia { get; set; }
    public DbSet<DepartamentoAluno> DepartamentoAluno { get; set; }
    public DbSet<Aluno> Aluno { get; set; }
    public DbSet<DepartamentoRISP> DepartamentoRISP { get; set; }
    public DbSet<RegioesSeguranca> RegioesSeguranca { get; set; }

    #endregion

    private static string PegarDatabase()
    {
#if DEBUG
      return "ConnectionLocal";
# else
  return "ConnectionProduction_Az";
#endif
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
      modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
      modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

      modelBuilder.Properties().Where(s => s.Name == s.ReflectedType.Name + "Id"
          || s.Name == s.ReflectedType.Name + "ID")
          .Configure(s => s.IsKey());

      modelBuilder.Properties<string>()
          .Configure(p => p.HasColumnType("varchar"));

      modelBuilder.Properties<string>()
          .Configure(p => p.HasMaxLength(500));


      #region ArquivoConfiguracao
      modelBuilder.Configurations.Add(new CandidatoConfiguration());
      modelBuilder.Configurations.Add(new DptoPoliciaConfiguration());
      modelBuilder.Configurations.Add(new AlunoConfiguration());
      #endregion
    }
  }
}
