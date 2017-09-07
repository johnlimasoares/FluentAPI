using System;
using DataAccess.Repositories.Base;
using Domain.Entities;

namespace DataAccess.Repositories
{
    public class TamanhoRepository : Repository<Tamanho>
    {
        public void Salvar(Tamanho tamanho)
        {
            using(ctx) {
                Save(tamanho);
                Commit();
            }
        }

        public void Atualizar(Tamanho tamanho)
        {
            using(ctx) {
                Update(tamanho);
                Commit();
            }
        }

        public void Excluir(Tamanho tamanho)
        {
            using(ctx) {
                Delete(x => x == tamanho);
                Commit();
            }
        }
    }
}
