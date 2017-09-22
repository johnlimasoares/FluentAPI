namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tabelasvendas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Venda", "ProdutoId", "dbo.Produto");
            DropIndex("dbo.Venda", new[] { "ProdutoId" });
            CreateTable(
                "dbo.ItemVenda",
                c => new
                    {
                        ItemVendaId = c.Int(nullable: false, identity: true),
                        DescricaoProduto = c.String(maxLength: 500, unicode: false),
                        Quantidade = c.Int(nullable: false),
                        PrecoBruto = c.Decimal(nullable: false, precision: 12, scale: 4),
                        PrecoLiquido = c.Decimal(nullable: false, precision: 12, scale: 4),
                        PercentualDesconto = c.Decimal(nullable: false, precision: 12, scale: 4),
                        ValorDesconto = c.Decimal(nullable: false, precision: 12, scale: 4),
                        Produto_ProdutoId = c.Int(),
                        Venda_VendaId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemVendaId)
                .ForeignKey("dbo.Produto", t => t.Produto_ProdutoId)
                .ForeignKey("dbo.Venda", t => t.Venda_VendaId)
                .Index(t => t.Produto_ProdutoId)
                .Index(t => t.Venda_VendaId);
            
            AddColumn("dbo.Venda", "DataHoraVenda", c => c.DateTime(nullable: false));
            AddColumn("dbo.Venda", "ValorTotalBruto", c => c.Decimal(nullable: false, precision: 12, scale: 4));
            AddColumn("dbo.Venda", "ValorTotalLiquido", c => c.Decimal(nullable: false, precision: 12, scale: 4));
            AddColumn("dbo.Venda", "ValorDesconto", c => c.Decimal(nullable: false, precision: 12, scale: 4));
            AddColumn("dbo.Venda", "PercentualDesconto", c => c.Decimal(nullable: false, precision: 12, scale: 4));
            AddColumn("dbo.Venda", "ClienteId", c => c.Int(nullable: false));
            CreateIndex("dbo.Venda", "ClienteId");
            AddForeignKey("dbo.Venda", "ClienteId", "dbo.Cliente", "ClienteId");
            DropColumn("dbo.Venda", "DataSaida");
            DropColumn("dbo.Venda", "PrecoVenda");
            DropColumn("dbo.Venda", "Quantidade");
            DropColumn("dbo.Venda", "ProdutoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Venda", "ProdutoId", c => c.Int(nullable: false));
            AddColumn("dbo.Venda", "Quantidade", c => c.Int(nullable: false));
            AddColumn("dbo.Venda", "PrecoVenda", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Venda", "DataSaida", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.ItemVenda", "Venda_VendaId", "dbo.Venda");
            DropForeignKey("dbo.ItemVenda", "Produto_ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.Venda", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.ItemVenda", new[] { "Venda_VendaId" });
            DropIndex("dbo.ItemVenda", new[] { "Produto_ProdutoId" });
            DropIndex("dbo.Venda", new[] { "ClienteId" });
            DropColumn("dbo.Venda", "ClienteId");
            DropColumn("dbo.Venda", "PercentualDesconto");
            DropColumn("dbo.Venda", "ValorDesconto");
            DropColumn("dbo.Venda", "ValorTotalLiquido");
            DropColumn("dbo.Venda", "ValorTotalBruto");
            DropColumn("dbo.Venda", "DataHoraVenda");
            DropTable("dbo.ItemVenda");
            CreateIndex("dbo.Venda", "ProdutoId");
            AddForeignKey("dbo.Venda", "ProdutoId", "dbo.Produto", "ProdutoId");
        }
    }
}
