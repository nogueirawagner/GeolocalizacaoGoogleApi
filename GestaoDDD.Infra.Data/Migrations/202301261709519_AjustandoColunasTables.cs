namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class AjustandoColunasTables : DbMigration
  {
    public override void Up()
    {
      CreateTable(
           "dbo.Cidade",
           c => new
           {
             Id = c.Int(nullable: false, identity: true),
             Codigo = c.String(nullable: false, maxLength: 200, unicode: false),
             CodigoCidade = c.String(nullable: false, maxLength: 500, unicode: false),
             NomeCidade = c.String(nullable: false, maxLength: 500, unicode: false),
             CodigoUf = c.String(nullable: false, maxLength: 500, unicode: false),
             CodigoPais = c.String(nullable: false, maxLength: 500, unicode: false),
             Pais = c.String(nullable: false, maxLength: 500, unicode: false),
             UF = c.Int(nullable: false),
           })
           .PrimaryKey(t => t.Id);

      DropColumn("dbo.Log", "DataHora");
    }

    public override void Down()
    {
      AddColumn("dbo.Log", "DataHora", c => c.DateTime(nullable: false));
      DropColumn("dbo.Cidade", "Regiao");
    }
  }
}
