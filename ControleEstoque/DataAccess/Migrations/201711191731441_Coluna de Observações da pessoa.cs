namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColunadeObservaçõesdapessoa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoa", "Observacoes", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pessoa", "Observacoes");
        }
    }
}
