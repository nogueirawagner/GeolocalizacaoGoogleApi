namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addposicao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aluno", "Posicao", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aluno", "Posicao");
        }
    }
}
