using System;
using DataAccess.Repositories.Base;
using Domain.Entities;

namespace DataAccess.Repositories
{
    public class CidadeRepository : Repository<Cidade>
    {
        public void Salvar(Cidade cidade)
        {
            using(ctx) {
                Save(cidade);
                Commit();
            }
        }

        public void Atualizar(Cidade cidade)
        {
            using(ctx) {
                Update(cidade);
                Commit();
            }
        }

        public void Excluir(Cidade cidade)
        {
            using(ctx) {
                Delete(x => x == cidade);
                Commit();
            }
        }
    }
}
