namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcargo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aluno", "Cargo", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aluno", "Cargo");
        }
    }
}
