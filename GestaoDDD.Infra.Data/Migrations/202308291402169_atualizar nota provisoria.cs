namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class atualizarnotaprovisoria : DbMigration
  {
    public override void Up()
    {
      Sql(@"update Aluno set NotaFinalProvisoria  = NotaFinal where Cargo = 'Agente' ");
    }

    public override void Down()
    {
    }
  }
}
