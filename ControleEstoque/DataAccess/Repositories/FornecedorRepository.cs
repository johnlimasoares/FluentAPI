using System;
using System.Linq;
using DataAccess.Repositories.Base;
using Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace DataAccess.Repositories
{
    public class FornecedorRepository : Repository<Fornecedor>
    {
      
        public override void Update(Fornecedor fornecedor)
        {
            using(ctx) {
                ctx.Entry(fornecedor.Pessoa).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void Delete(Fornecedor fornecedor)
        {
            using(ctx) {
                base.Delete(x => x == fornecedor);
                Commit();
            }
        }

        public Fornecedor Find(int id)
        {
            return ctx.Set<Fornecedor>().Include("Pessoa").SingleOrDefault(x => x.FornecedorId == id);
        }

        public List<Fornecedor> GetAll(Func<Fornecedor, bool> where = null)
        {
            if(where == null)
                return base.GetAll().Include("Pessoa").AsNoTracking().ToList();

            return base.GetAll().Include("Pessoa").AsNoTracking().Where(where).ToList();
        }
    }
}
