namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class AddCampo : DbMigration
  {
    public override void Up()
    {
      DropForeignKey("dbo.Servico", "categoria_id", "dbo.Categoria");
      DropForeignKey("dbo.OrcamentoPrestador", "orcamento_id_fk", "dbo.Orcamento");
      DropForeignKey("dbo.OrcamentoPrestador", "prestador_id_fk", "dbo.Prestador");
      DropForeignKey("dbo.Prestador", "Id", "dbo.AspNetUsers");
      DropForeignKey("dbo.ServicoPrestador", "pres_Id", "dbo.Prestador");
      DropForeignKey("dbo.ServicoPrestador", "serv_Id", "dbo.Servico");
      DropForeignKey("dbo.IndiqueProfissional", "Servico_serv_Id", "dbo.Servico");
      DropIndex("dbo.Servico", new[] { "categoria_id" });
      DropIndex("dbo.ServicoPrestador", new[] { "pres_Id" });
      DropIndex("dbo.ServicoPrestador", new[] { "serv_Id" });
      DropIndex("dbo.Prestador", new[] { "Id" });
      DropIndex("dbo.IndiqueProfissional", new[] { "Servico_serv_Id" });
      DropIndex("dbo.OrcamentoPrestador", new[] { "orcamento_id_fk" });
      DropIndex("dbo.OrcamentoPrestador", new[] { "prestador_id_fk" });
    }

    public override void Down() { }
  }
}
