using DataAccess;
using Domain.DTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using static Business.EnderecoBusiness;
using static Business.TelefoneBusiness;
namespace Business
{
    public static class FornecedorBusiness
    {
        public static void Salvar(DataContext ctx, Pessoa pessoa, List<EnderecoDTO> listEnderecoDTO, List<TelefoneDTO> listTelefoneDTO)
        {
            ctx.Pessoas.Add(pessoa);
            var fornecedor = new Fornecedor();
            fornecedor.Pessoa = pessoa;
            ctx.Fornecedores.Add(fornecedor);
            GerenciarOperacoesDeEnderecos(ctx, pessoa, listEnderecoDTO, true);
            GerenciarOperacoesDeTelefones(ctx, pessoa, listTelefoneDTO, true);
            ctx.SaveChanges();
        }

        public static void Atualizar(DataContext ctx, Pessoa pessoa, List<EnderecoDTO> listEnderecoDTO, List<TelefoneDTO> listTelefoneDTO)
        {
            GerenciarOperacoesDeEnderecos(ctx, pessoa, listEnderecoDTO, false);
            GerenciarOperacoesDeTelefones(ctx, pessoa, listTelefoneDTO, false);
            ctx.Entry(pessoa).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public static Fornecedor GetFornecedor(DataContext ctx, int FornecedorId)
        {
            return ctx.Set<Fornecedor>()
                .Include("Pessoa")
                .Where(x => x.FornecedorId == FornecedorId)
                .AsNoTracking()
                .SingleOrDefault();
        }

        public static List<Fornecedor> GetAll(Func<Fornecedor, bool> where = null)
        {
            using(var ctx = new DataContext()) {
                if(where == null)
                    return ctx.Set<Fornecedor>().Include("Pessoa").AsNoTracking().ToList();

                return ctx.Set<Fornecedor>().Include("Pessoa").AsNoTracking().Where(where).ToList();
            }
        }

        public static Fornecedor Find(int id)
        {
            using(var ctx = new DataContext()) { 
                return ctx.Set<Fornecedor>().Include("Pessoa").SingleOrDefault(x => x.FornecedorId == id);
            }
        }

        public static void Delete(int fornecedorId)
        {
            using(var ctx = new DataContext()) {
                ctx.Fornecedores.Remove(ctx.Set<Fornecedor>().Find(fornecedorId));
                ctx.SaveChanges();
            }
        }
    }
}
