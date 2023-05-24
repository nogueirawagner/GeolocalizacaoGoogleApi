namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlatitudeelongitutde : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DepartamentoPolicia", "Latitude", c => c.String(maxLength: 500, unicode: false));
            AddColumn("dbo.DepartamentoPolicia", "Longitude", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DepartamentoPolicia", "Longitude");
            DropColumn("dbo.DepartamentoPolicia", "Latitude");
        }
    }
}
