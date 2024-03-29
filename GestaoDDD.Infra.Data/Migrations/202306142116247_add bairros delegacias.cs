namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbairrosdelegacias : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DepartamentoPolicia", "Bairro", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DepartamentoPolicia", "Bairro");
        }
    }
}
