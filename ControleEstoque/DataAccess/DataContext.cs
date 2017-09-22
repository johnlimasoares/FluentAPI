using DataAccess.Map;
using Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
/**
    Enable-Migrations - Executar somente na primeira vez
    Add-Migration “nome_migrations” – cria um alteração no banco de dados, onde o “nome_migrations” é o nome que você irá dar para a atualização;
    Update-DataBase – aplica as alterações no banco de dados;
    Update-DataBase – script – gera um script com os comandos SQL para serem executados no banco de dados.

    Se você estiver implantando seu aplicativo, você pode querer atualizar automaticamente o banco de dados (aplicando as migrações pendentes) quando o 
    aplicativo for iniciado. Você pode fazer isso registrando o inicializador do banco de dados MigrateDatabaseToLatestVersion . 
    Um inicializador de banco de dados simplesmente contém alguma lógica que é usada para garantir que o banco de dados esteja configurado corretamente. 
    Essa lógica é executada pela primeira vez que o contexto é usado dentro do processo do aplicativo. 
    Utilizado nesta aplicação na classe Program do projeto ControleEstoque
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
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Tamanho> Tamanhos { get; set; }
        public DbSet<Cor> Cores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

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
            modelBuilder.Properties<decimal>()
                .Configure(c => c.HasPrecision(12, 4));


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
            modelBuilder.Configurations.Add(new ClienteMap());

        }
    }
}
