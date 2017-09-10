namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCadastrodeClientes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
            AlterColumn("dbo.Endereco", "CEP", c => c.String(maxLength: 8, unicode: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "PessoaId", "dbo.Pessoa");
            DropIndex("dbo.Cliente", new[] { "PessoaId" });
            AlterColumn("dbo.Endereco", "CEP", c => c.String(maxLength: 500, unicode: false));
            DropTable("dbo.Cliente");
        }
    }
}
