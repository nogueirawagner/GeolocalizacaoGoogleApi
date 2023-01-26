namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class AddDescricaoCategoria : DbMigration
  {
    public override void Up()
    {
      CreateTable(
            "dbo.Log",
            c => new
            {
              Id = c.Int(nullable: false, identity: true),
              Mensagem = c.String(nullable: false, maxLength: 200, unicode: false),
              Controller = c.String(nullable: false, maxLength: 500, unicode: false),
              View = c.String(nullable: false, maxLength: 500, unicode: false),
            })
            .PrimaryKey(t => t.Id);

      AddColumn("dbo.Categoria", "Descricao", c => c.String(maxLength: 500, unicode: false));
      AddColumn("dbo.Log", "DataHora", c => c.DateTime(nullable: false));
    }

    public override void Down()
    {
      DropColumn("dbo.Log", "DataHora");
      DropColumn("dbo.Categoria", "Descricao");
    }
  }
}
