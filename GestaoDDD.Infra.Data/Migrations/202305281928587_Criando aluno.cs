namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criandoaluno : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aluno",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Inscricao = c.String(maxLength: 500, unicode: false),
                        Nome = c.String(maxLength: 500, unicode: false),
                        Concorrencia = c.String(maxLength: 500, unicode: false),
                        NotaEtapa1 = c.Single(nullable: false),
                        NotaEtapa2 = c.Single(nullable: false),
                        NotaSAT = c.Single(nullable: false),
                        NotaTIPDPP = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Aluno");
        }
    }
}
