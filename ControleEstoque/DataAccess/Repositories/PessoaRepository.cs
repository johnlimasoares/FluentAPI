using System;
using DataAccess.Repositories.Base;
using Domain.Entities;

namespace DataAccess.Repositories
{
    public class PessoaoRepository : Repository<Pessoa>
    {
        public void Salvar(Pessoa pessoa)
        {
            using(ctx) {
                Save(pessoa);
                Commit();
            }
        }

        public void Atualizar(Pessoa pessoa)
        {
            using(ctx) {
                Update(pessoa);
                Commit();
            }
        }

        public void Excluir(Pessoa pessoa)
        {
            using(ctx) {
                Delete(x => x == pessoa);
                Commit();
            }
        }
    }
}
