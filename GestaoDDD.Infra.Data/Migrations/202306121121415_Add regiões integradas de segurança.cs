namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addregiõesintegradasdesegurança : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepartamentoRISP",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DptoId = c.Int(nullable: false),
                        RispId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RegioesSeguranca",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegioesSeguranca");
            DropTable("dbo.DepartamentoRISP");
        }
    }
}
