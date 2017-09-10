using System.Collections.Generic;
using DataAccess;
using Domain.DTO;
using Domain.Entities;
using System.Data.Entity;
using System.Linq;
using static Business.TelefoneBusiness;
using static Business.EnderecoBusiness;
using System;

namespace Business
{
    public static class ClienteBusiness
    {
        public static void Salvar(DataContext ctx, Pessoa pessoa, List<EnderecoDTO> listEnderecoDTO, List<TelefoneDTO> listTelefoneDTO)
        {
            ctx.Pessoas.Add(pessoa);
            var cliente = new Cliente();
            cliente.Pessoa = pessoa;
            ctx.Clientes.Add(cliente);
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

        public static Cliente GetCliente(DataContext ctx, int clienteId)
        {
            return ctx.Set<Cliente>()
                .Include("Pessoa")
                .Where(x => x.ClienteId == clienteId)
                .AsNoTracking()
                .SingleOrDefault();

        }

        public static List<Cliente> GetAll(Func<Cliente, bool> where = null)
        {
            using(var ctx = new DataContext()) {
                if(where == null)
                    return ctx.Set<Cliente>().Include("Pessoa").AsNoTracking().ToList();

                return ctx.Set<Cliente>().Include("Pessoa").AsNoTracking().Where(where).ToList();
            }
        }

        public static Cliente Find(int id)
        {
            using(var ctx = new DataContext()) {
                return ctx.Set<Cliente>().Include("Pessoa").SingleOrDefault(x => x.ClienteId == id);
            }
        }

        public static void Delete(int clienteId)
        {
            using(var ctx = new DataContext()) {
                ctx.Clientes
                    .Remove(ctx.Set<Cliente>().Find(clienteId));
                ctx.SaveChanges();
            }
        }
    }
}
