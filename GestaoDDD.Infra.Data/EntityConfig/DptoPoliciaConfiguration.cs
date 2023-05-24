using GestaoDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GestaoDDD.Infra.Data.EntityConfig
{
    public class DptoPoliciaConfiguration : EntityTypeConfiguration<DepartamentoPolicia>
    {
        public DptoPoliciaConfiguration()
        {
            HasKey(c => c.ID);
            Property(c => c.ID).HasColumnName("ID").HasColumnOrder(1);
        }
    }
}
