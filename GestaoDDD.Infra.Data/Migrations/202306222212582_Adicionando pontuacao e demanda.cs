namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class Adicionandopontuacaoedemanda : DbMigration
  {
    public override void Up()
    {
      AddColumn("dbo.DepartamentoPolicia", "Pontuacao", c => c.Int(nullable: false));

    }

    public override void Down()
    {
      DropColumn("dbo.DepartamentoPolicia", "Pontuacao");
    }
  }
}
