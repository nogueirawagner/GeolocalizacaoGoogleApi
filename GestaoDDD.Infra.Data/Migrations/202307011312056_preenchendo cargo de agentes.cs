namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class preenchendocargodeagentes : DbMigration
  {
    public override void Up()
    {
      Sql(@"update Aluno set Cargo = 'Agente'");
    }

    public override void Down()
    {
    }
  }
}
