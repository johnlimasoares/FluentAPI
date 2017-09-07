using System;
using System.Collections.Generic;
using DataAccess.Repositories.Base;
using Domain.Entities;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Repositories
{
    public class ProdutoRepository : Repository<Produto>
    {
        public void Salvar(Produto produto)
        {
            //ctx.Entry(produto.Marca).State = System.Data.Entity.EntityState.Unchanged;
            //ctx.Entry(produto.Grupo).State = System.Data.Entity.EntityState.Unchanged;
            //ctx.Entry(produto.Fornecedor).State = System.Data.Entity.EntityState.Unchanged;
            //ctx.Entry(produto.Tamanho).State = System.Data.Entity.EntityState.Unchanged;
            //ctx.Entry(produto.Cor).State = System.Data.Entity.EntityState.Unchanged;
            //ctx.Produtos.Add(produto);
            //Commit();
            //return produto;
        }

        public void Atualizar(Produto produto)
        {
            ctx.Configuration.AutoDetectChangesEnabled = true;
            Commit();
        }

        public Produto Find(int id)
        {
            return ctx.Set<Produto>()
                    .Include("Grupo")
                    .Include("Marca")
                    .Include("Tamanho")
                    .Include("Cor")
                    .Include(e => e.Fornecedor.Pessoa)
                    .Single(x => x.ProdutoId == id);
        }

        public IQueryable<Produto> GetAll()
        {
            return base.GetAll()
                       .Include("Grupo")
                       .Include("Marca")
                       .Include("Tamanho")
                       .Include("Cor");
        }
    }
}
