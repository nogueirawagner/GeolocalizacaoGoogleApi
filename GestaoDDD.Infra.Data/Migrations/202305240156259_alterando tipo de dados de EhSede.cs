namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterandotipodedadosdeEhSede : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DepartamentoPolicia", "EhSede", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DepartamentoPolicia", "EhSede", c => c.Boolean(nullable: false));
        }
    }
}
