using DataAccess;
using Domain.Entities;
using System.Data.Entity;
using System.Linq;

namespace Business
{
    public static class PessoaBusiness
    {
        public static Pessoa GetPessoa(DataContext ctx, int pessoaId)
        {
            return ctx.Set<Pessoa>()
                .Where(x => x.PessoaId == pessoaId)
                .AsNoTracking()
                .FirstOrDefault();
        }
    }
}
