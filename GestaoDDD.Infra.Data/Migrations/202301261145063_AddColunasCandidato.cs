namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColunasCandidato : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidato", "Descricao", c => c.String(maxLength: 500, unicode: false));
            AddColumn("dbo.Candidato", "QtdVagas", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Candidato", "QtdVagas");
            DropColumn("dbo.Candidato", "Descricao");
        }
    }
}
