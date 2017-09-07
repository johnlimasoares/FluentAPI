using System;
using DataAccess.Repositories.Base;
using Domain.Entities;

namespace DataAccess.Repositories
{
    public class CorRepository : Repository<Cor>
    {
        public void Salvar(Cor cor)
        {
            using(ctx) {
                Save(cor);
                Commit();
            }
        }

        public void Atualizar(Cor cor)
        {
            using(ctx) {
                Update(cor);
                Commit();
            }
        }

        public void Excluir(Cor cor)
        {
            using(ctx) {
                Delete(x => x == cor);
                Commit();
            }
        }
    }
}
