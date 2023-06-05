namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removendonotasatetipaluno : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Aluno", "NotaSAT");
            DropColumn("dbo.Aluno", "NotaTIPDPP");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Aluno", "NotaTIPDPP", c => c.Double(nullable: false));
            AddColumn("dbo.Aluno", "NotaSAT", c => c.Double(nullable: false));
        }
    }
}
