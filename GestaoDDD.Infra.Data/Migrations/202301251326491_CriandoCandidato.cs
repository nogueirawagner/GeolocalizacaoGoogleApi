namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoCandidato : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidato",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 500, unicode: false),
                        Telefone = c.String(maxLength: 500, unicode: false),
                        TipoVeiculo = c.String(maxLength: 500, unicode: false),
                        latitude = c.String(maxLength: 500, unicode: false),
                        longitude = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Candidato");
        }
    }
}
