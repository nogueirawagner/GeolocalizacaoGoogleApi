namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTurma : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidato", "Turma", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Candidato", "Turma");
        }
    }
}
