using DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class PessoaBusiness
    {
        public static Pessoa GetPessoa(DataContext ctx, int pessoaId)
        {
            return ctx.Set<Pessoa>()
                .Where(x => x.PessoaId == pessoaId)
                .FirstOrDefault();
        }
    }
}
