namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criandorelacionamentodedepartamentoealuno : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepartamentoAluno",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AlunoID = c.Int(nullable: false),
                        DptoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DepartamentoAluno");
        }
    }
}
