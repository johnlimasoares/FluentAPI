using System;
using DataAccess.Repositories.Base;
using Domain.Entities;

namespace DataAccess.Repositories
{
    public class MarcaRepository : Repository<Marca>
    {
        public void Salvar(Marca marca)
        {
            using(ctx) {
                Save(marca);
                Commit();
            }
        }

        public void Atualizar(Marca marca)
        {
            using(ctx) {
                Update(marca);
                Commit();
            }
        }

        public void Excluir(Marca marca)
        {
            using(ctx) {
                Delete(x => x == marca);
                Commit();
            }
        }
    }
}
