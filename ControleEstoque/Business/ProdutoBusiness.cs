using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DataAccess;
using Domain.Entities;
using System.Linq;
using System.Data.Entity;

namespace Business
{
    public static class ProdutoBusiness
    {
        public static void Salvar(Produto produto)
        {
            using(var ctx = new DataContext()) {
                ctx.Entry(produto.Marca).State = System.Data.Entity.EntityState.Unchanged;
                ctx.Entry(produto.Grupo).State = System.Data.Entity.EntityState.Unchanged;
                ctx.Entry(produto.Fornecedor).State = System.Data.Entity.EntityState.Unchanged;
                ctx.Entry(produto.Tamanho).State = System.Data.Entity.EntityState.Unchanged;
                ctx.Entry(produto.Cor).State = System.Data.Entity.EntityState.Unchanged;
                ctx.Produtos.Add(produto);
                ctx.SaveChanges();
            }
        }

        public static void Atualizar(DataContext ctx, Produto produto, int marcaId, int grupoId, int fornecedorId, int tamanhoId, int corId)
        {
            produto.Marca = ctx.Marcas.Find(marcaId);
            produto.Grupo = ctx.Grupos.Find(grupoId);
            produto.Fornecedor = ctx.Fornecedores.Include("Pessoa").Single(x => x.FornecedorId == fornecedorId);
            produto.Tamanho = ctx.Tamanhos.Find(tamanhoId);
            produto.Cor = ctx.Cores.Find(corId);
            ctx.Configuration.AutoDetectChangesEnabled = true;
            ctx.SaveChanges();
        }

        public static void InativarProduto(int idProduto)
        {
            using(var ctx = new DataContext()) {
                var produto = ctx.Produtos.Find(idProduto);
                produto.IsInativo = true;
                ctx.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public static List<Produto> GetProdutos(Expression<Func<Produto, bool>> where)
        {
            using(var ctx = new DataContext()) {
                var query = ctx.Set<Produto>()
                    .Include("Grupo")
                    .Include("Marca")
                    .Include("Tamanho")
                    .Include("Cor").
                    Where(where);
                return query.AsNoTracking().ToList();
            }
        }
    }
}
