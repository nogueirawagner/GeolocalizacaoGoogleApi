namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterandoaluno : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Aluno", "NotaEtapa1", c => c.Double(nullable: false));
            AlterColumn("dbo.Aluno", "NotaEtapa2", c => c.Double(nullable: false));
            AlterColumn("dbo.Aluno", "NotaSAT", c => c.Double(nullable: false));
            AlterColumn("dbo.Aluno", "NotaTIPDPP", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Aluno", "NotaTIPDPP", c => c.Single(nullable: false));
            AlterColumn("dbo.Aluno", "NotaSAT", c => c.Single(nullable: false));
            AlterColumn("dbo.Aluno", "NotaEtapa2", c => c.Single(nullable: false));
            AlterColumn("dbo.Aluno", "NotaEtapa1", c => c.Single(nullable: false));
        }
    }
}
