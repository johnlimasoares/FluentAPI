namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColunadeUFdacidade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cidade", "UF", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cidade", "UF");
        }
    }
}
