namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandodepartamentosdePolícia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepartamentoPolicia",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EhSede = c.Boolean(nullable: false),
                        Nome = c.String(maxLength: 500, unicode: false),
                        AreaAtuacao = c.String(maxLength: 500, unicode: false),
                        Endereco = c.String(maxLength: 500, unicode: false),
                        Descricao = c.String(maxLength: 500, unicode: false),
                        Vagas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DepartamentoPolicia");
        }
    }
}
