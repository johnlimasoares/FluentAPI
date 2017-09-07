﻿using DataAccess.Map;
using Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
/**
    Enable-Migrations - Executar somente na primeira vez
    Add-Migration “nome_migrations” – cria um alteração no banco de dados, onde o “nome_migrations” é o nome que você irá dar para a atualização;
    Update-DataBase – aplica as alterações no banco de dados;
    Update-DataBase – script – gera um script com os comandos SQL para serem executados no banco de dados.
**/
namespace DataAccess
{
    public class DataContext : System.Data.Entity.DbContext
    {
        public DataContext() : base("Conexao")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Produto> Produtos{ get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Venda> SaidaMercadorias { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Tamanho> Tamanhos { get; set; }
        public DbSet<Cor> Cores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties()
                   .Where(p => p.Name == p.ReflectedType.Name + "Id")
                   .Configure(p => p.IsKey());
            modelBuilder.Properties<string>()
                   .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                  .Configure(p => p.HasMaxLength(500));

            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new MarcaMap());
            modelBuilder.Configurations.Add(new GrupoMap());
            modelBuilder.Configurations.Add(new VendaMap());
            modelBuilder.Configurations.Add(new PessoaMap());
            modelBuilder.Configurations.Add(new FornecedorMap());
            modelBuilder.Configurations.Add(new TamanhoMap());
            modelBuilder.Configurations.Add(new CorMap());
            modelBuilder.Configurations.Add(new CidadeMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new TelefoneMap());

        }
    }
}