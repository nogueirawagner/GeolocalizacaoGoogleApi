namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class createindexalunoconcorrencia : DbMigration
  {
    public override void Up()
    {
      Sql(@"

          SET ANSI_PADDING ON
          GO

          /****** Object:  Index [Idx_Aluno]    Script Date: 22/06/2023 14:00:36 ******/
          CREATE UNIQUE NONCLUSTERED INDEX [Idx_Aluno] ON [dbo].[Aluno]
          (
	          [Nome] ASC,
	          [Concorrencia] ASC
          )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
          GO
        ");
    }

    public override void Down()
    {
    }
  }
}
