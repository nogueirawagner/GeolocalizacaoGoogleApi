namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcamponotafinalparaaluno : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aluno", "NotaFinal", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aluno", "NotaFinal");
        }
    }
}
