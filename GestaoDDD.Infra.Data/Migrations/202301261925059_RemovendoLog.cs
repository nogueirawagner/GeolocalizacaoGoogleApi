namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class RemovendoLog : DbMigration
  {
    public override void Up()
    {
      
    }

    public override void Down()
    {
      AddColumn("dbo.Cidade", "Regiao", c => c.String(maxLength: 500, unicode: false));
    }
  }
}
