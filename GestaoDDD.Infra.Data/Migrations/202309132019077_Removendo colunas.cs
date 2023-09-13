namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removendocolunas : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Aluno", "NotaFinalProvisoria");
            DropColumn("dbo.Aluno", "PosicaoProvisoria");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Aluno", "PosicaoProvisoria", c => c.Int(nullable: false));
            AddColumn("dbo.Aluno", "NotaFinalProvisoria", c => c.Double(nullable: false));
        }
    }
}
