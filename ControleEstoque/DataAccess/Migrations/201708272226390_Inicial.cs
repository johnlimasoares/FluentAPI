namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidade",
                c => new
                    {
                        CidadeId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.CidadeId);
            
            CreateTable(
                "dbo.Cor",
                c => new
                    {
                        CorId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.CorId);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        EnderecoId = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(nullable: false, maxLength: 100, unicode: false),
                        CEP = c.String(maxLength: 500, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 15, unicode: false),
                        TipoEndereco = c.String(nullable: false, maxLength: 20, unicode: false),
                        CidadeId = c.Int(nullable: false),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnderecoId)
                .ForeignKey("dbo.Cidade", t => t.CidadeId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.CidadeId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        PessoaId = c.Int(nullable: false, identity: true),
                        NomeRazao = c.String(nullable: false, maxLength: 50, unicode: false),
                        ApelidoFantasia = c.String(nullable: false, maxLength: 50, unicode: false),
                        CpfCnpj = c.String(nullable: false, maxLength: 14, unicode: false),
                        RgIe = c.String(nullable: false, maxLength: 20, unicode: false),
                        TipoPessoa = c.String(nullable: false, maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.PessoaId);
            
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        FornecedorId = c.Int(nullable: false, identity: true),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FornecedorId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.Grupo",
                c => new
                    {
                        GrupoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.GrupoId);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        MarcaId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.MarcaId);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100, unicode: false),
                        CodigoProduto = c.String(nullable: false, maxLength: 50, unicode: false),
                        PrecoCompra = c.Decimal(nullable: false, precision: 12, scale: 4),
                        PrecoVenda = c.Decimal(nullable: false, precision: 12, scale: 4),
                        Localizacao = c.String(maxLength: 50, unicode: false),
                        Observacao = c.String(maxLength: 500, unicode: false),
                        EstoqueAtual = c.Int(nullable: false),
                        IsInativo = c.Boolean(nullable: false),
                        DataUltimaAtualizacao = c.DateTime(nullable: false),
                        CorId = c.Int(nullable: false),
                        FornecedorId = c.Int(nullable: false),
                        GrupoId = c.Int(nullable: false),
                        MarcaId = c.Int(nullable: false),
                        TamanhoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId)
                .ForeignKey("dbo.Cor", t => t.CorId)
                .ForeignKey("dbo.Fornecedor", t => t.FornecedorId)
                .ForeignKey("dbo.Grupo", t => t.GrupoId)
                .ForeignKey("dbo.Marca", t => t.MarcaId)
                .ForeignKey("dbo.Tamanho", t => t.TamanhoId)
                .Index(t => t.CorId)
                .Index(t => t.FornecedorId)
                .Index(t => t.GrupoId)
                .Index(t => t.MarcaId)
                .Index(t => t.TamanhoId);
            
            CreateTable(
                "dbo.Tamanho",
                c => new
                    {
                        TamanhoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 2, unicode: false),
                    })
                .PrimaryKey(t => t.TamanhoId);
            
            CreateTable(
                "dbo.Venda",
                c => new
                    {
                        VendaId = c.Int(nullable: false, identity: true),
                        DataSaida = c.DateTime(nullable: false),
                        PrecoVenda = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantidade = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VendaId)
                .ForeignKey("dbo.Produto", t => t.ProdutoId)
                .Index(t => t.ProdutoId);
            
            CreateTable(
                "dbo.Telefone",
                c => new
                    {
                        TelefoneId = c.Int(nullable: false, identity: true),
                        Numero = c.String(nullable: false, maxLength: 12, unicode: false),
                        TipoFone = c.String(nullable: false, maxLength: 20, unicode: false),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TelefoneId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telefone", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.Venda", "ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.Produto", "TamanhoId", "dbo.Tamanho");
            DropForeignKey("dbo.Produto", "MarcaId", "dbo.Marca");
            DropForeignKey("dbo.Produto", "GrupoId", "dbo.Grupo");
            DropForeignKey("dbo.Produto", "FornecedorId", "dbo.Fornecedor");
            DropForeignKey("dbo.Produto", "CorId", "dbo.Cor");
            DropForeignKey("dbo.Fornecedor", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.Endereco", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.Endereco", "CidadeId", "dbo.Cidade");
            DropIndex("dbo.Telefone", new[] { "PessoaId" });
            DropIndex("dbo.Venda", new[] { "ProdutoId" });
            DropIndex("dbo.Produto", new[] { "TamanhoId" });
            DropIndex("dbo.Produto", new[] { "MarcaId" });
            DropIndex("dbo.Produto", new[] { "GrupoId" });
            DropIndex("dbo.Produto", new[] { "FornecedorId" });
            DropIndex("dbo.Produto", new[] { "CorId" });
            DropIndex("dbo.Fornecedor", new[] { "PessoaId" });
            DropIndex("dbo.Endereco", new[] { "PessoaId" });
            DropIndex("dbo.Endereco", new[] { "CidadeId" });
            DropTable("dbo.Telefone");
            DropTable("dbo.Venda");
            DropTable("dbo.Tamanho");
            DropTable("dbo.Produto");
            DropTable("dbo.Marca");
            DropTable("dbo.Grupo");
            DropTable("dbo.Fornecedor");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Endereco");
            DropTable("dbo.Cor");
            DropTable("dbo.Cidade");
        }
    }
}
