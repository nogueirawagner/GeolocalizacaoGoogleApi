namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoCidade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cidade", "Mundo", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categoria", "Testando", c => c.String(maxLength: 500, unicode: false));
            DropColumn("dbo.Cidade", "Mundo");
        }
    }
}
