namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionandoCamposcandidato : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidato", "QtdVagasCarro", c => c.String(maxLength: 500, unicode: false));
            AddColumn("dbo.Candidato", "Valor", c => c.Double(nullable: false));
            AddColumn("dbo.Candidato", "QtdVagasDisponivelCasa", c => c.Int(nullable: false));
            DropColumn("dbo.Candidato", "QtdVagas");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Candidato", "QtdVagas", c => c.String(maxLength: 500, unicode: false));
            DropColumn("dbo.Candidato", "QtdVagasDisponivelCasa");
            DropColumn("dbo.Candidato", "Valor");
            DropColumn("dbo.Candidato", "QtdVagasCarro");
        }
    }
}
