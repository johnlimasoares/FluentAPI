using DataAccess;
using Domain.DTO;
using Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Business
{
    public static class TelefoneBusiness
    {
        public static void GerenciarOperacoesDeTelefones(DataContext ctx, Pessoa pessoa, List<TelefoneDTO> listTelefoneDTO, bool isInsert)
        {

            foreach(var telefoneoDTO in listTelefoneDTO) {
                if(isInsert) {
                    SalvarTelefone(ctx, pessoa, telefoneoDTO);
                }

                else 
                {
                    if(telefoneoDTO.IsDeleted) {
                        ExcluirTelefone(ctx, telefoneoDTO);
                    }
                    else if(telefoneoDTO.IsPersisted) {
                        AtualizarTelefone(ctx, pessoa, telefoneoDTO);
                    }
                    else {
                        SalvarTelefone(ctx, pessoa, telefoneoDTO);
                    }

                }
            }
        }

        public static List<TelefoneDTO> GetAllFones(DataContext ctx, Pessoa pessoa)
        {
            return ctx.Set<Telefone>()
                .Include("Pessoa")
                .Where(x => x.Pessoa.PessoaId == pessoa.PessoaId)
                .AsNoTracking()
                .ToListFonesDTO();
        }

        public static List<TelefoneDTO> ToListFonesDTO(this IEnumerable<Telefone> listFones)
        {
            var listTelefoneDTO = new List<TelefoneDTO>();
            foreach(var fone in listFones) {
                var telefoneDTO = new TelefoneDTO();
                telefoneDTO.TelefoneId = fone.TelefoneId;
                telefoneDTO.Numero = fone.Numero;
                telefoneDTO.TipoFone = fone.TipoFone;
                telefoneDTO.Pessoa = fone.Pessoa;
                telefoneDTO.IsPersisted = true;
                listTelefoneDTO.Add(telefoneDTO);
            }
            return listTelefoneDTO;
        }

        public static Telefone GetTelefone(DataContext ctx, int telefoneId)
        {
            return ctx.Set<Telefone>()
                .Where(x => x.TelefoneId == telefoneId)
                .FirstOrDefault();
        }

        private static void SalvarTelefone(DataContext ctx, Pessoa pessoa, TelefoneDTO telefoneDTO)
        {
            var telefone = new Telefone();
            telefone.Numero = telefoneDTO.Numero;
            telefone.TipoFone = telefoneDTO.TipoFone;
            telefone.Pessoa = pessoa;
            ctx.Telefones.Add(telefone);
        }

        private static void AtualizarTelefone(DataContext ctx, Pessoa pessoa, TelefoneDTO telefoneDTO)
        {
            var telefone = GetTelefone(ctx, telefoneDTO.TelefoneId);
            telefone.Numero = telefoneDTO.Numero;
            telefone.TipoFone = telefoneDTO.TipoFone;
            telefone.Pessoa = pessoa;
            ctx.Entry(telefone).State = EntityState.Modified;
        }

        private static void ExcluirTelefone(DataContext ctx, TelefoneDTO telefoneDTO)
        {
            ctx.Telefones.Remove(ctx.Set<Telefone>().Find(telefoneDTO.TelefoneId));
        }
    }
}
