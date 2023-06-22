namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DepartamentoPolicia", "Pontuacao", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DepartamentoPolicia", "Pontuacao", c => c.String(maxLength: 500, unicode: false));
        }
    }
}
