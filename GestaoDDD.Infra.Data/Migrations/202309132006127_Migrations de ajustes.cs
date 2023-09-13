namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class Migrationsdeajustes : DbMigration
  {
    public override void Up()
    {
      Sql(@"update Aluno set NotaEtapa2 = 0 where Cargo = 'Agente'");
    }

    public override void Down()
    {
    }
  }
}
