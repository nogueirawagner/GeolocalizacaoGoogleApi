namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class addposicaoprovisoria : DbMigration
  {
    public override void Up()
    {
      AddColumn("dbo.Aluno", "PosicaoProvisoria", c => c.Int(nullable: false));
      Sql("update Aluno set PosicaoProvisoria = Posicao where Cargo = 'Agente'");
    }

    public override void Down()
    {
      DropColumn("dbo.Aluno", "PosicaoProvisoria");
    }
  }
}
