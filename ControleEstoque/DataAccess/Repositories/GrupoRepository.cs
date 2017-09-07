using System;
using DataAccess.Repositories.Base;
using Domain.Entities;

namespace DataAccess.Repositories
{
    public class GrupoRepository : Repository<Grupo>
    {
        public void Salvar(Grupo grupo)
        {
            using(ctx) {
                Save(grupo);
                Commit();
            }
        }

        public void Atualizar(Grupo grupo)
        {
            using(ctx) {
                Update(grupo);
                Commit();
            }
        }

        public void Excluir(Grupo grupo)
        {
            using(ctx) {
                Delete(x => x == grupo);
                Commit();
            }
        }
    }
}
