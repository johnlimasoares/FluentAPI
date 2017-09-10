using DataAccess;
using Domain.DTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class EnderecoBusiness
    {
        public static void GerenciarOperacoesDeEnderecos(DataContext ctx, Pessoa pessoa, List<EnderecoDTO> listEnderecoDTO, bool isInsert)
        {
            foreach(var enderecoDTO in listEnderecoDTO) {
                if(isInsert) {
                    SalvarEndereco(ctx, pessoa, enderecoDTO);
                }
                else {
                    if(enderecoDTO.IsDeleted) {
                        ExcluirEndereco(ctx, enderecoDTO);
                    }
                    else if(enderecoDTO.IsPersisted) {
                        AtualizarEndereco(ctx, pessoa, enderecoDTO);
                    }
                    else {
                        SalvarEndereco(ctx, pessoa, enderecoDTO);
                    }
                }
            }
        }

        public static List<EnderecoDTO> GetAllEnderecos(DataContext ctx, Pessoa pessoa)
        {
            return ctx.Set<Endereco>()
                .Include("Cidade")
                .Include("Pessoa")
                .Where(x => x.Pessoa.PessoaId == pessoa.PessoaId)
                .AsNoTracking()
                .ToListEnderecoDTO();
        }

        public static List<EnderecoDTO> ToListEnderecoDTO(this IEnumerable<Endereco> listEndereco)
        {
            var listEnderecoDTO = new List<EnderecoDTO>();
            foreach(var endereco in listEndereco) {
                var enderecoDTO = new EnderecoDTO();
                enderecoDTO.EnderecoId = endereco.EnderecoId;
                enderecoDTO.Numero = endereco.Numero;
                enderecoDTO.Logradouro = endereco.Logradouro;
                enderecoDTO.CEP = endereco.CEP;
                enderecoDTO.TipoEndereco = endereco.TipoEndereco;
                enderecoDTO.Cidade = endereco.Cidade;
                enderecoDTO.Pessoa = endereco.Pessoa;
                enderecoDTO.IsPersisted = true;
                listEnderecoDTO.Add(enderecoDTO);
            }

            return listEnderecoDTO;
        }

        private static void SalvarEndereco(DataContext ctx, Pessoa pessoa, EnderecoDTO enderecoDTO)
        {
            var endereco = new Endereco();
            endereco.Numero = enderecoDTO.Numero;
            endereco.Logradouro = enderecoDTO.Logradouro;
            endereco.CEP = enderecoDTO.CEP;
            endereco.TipoEndereco = enderecoDTO.TipoEndereco;
            endereco.Pessoa = pessoa;
            endereco.Cidade = GetCidade(ctx, enderecoDTO.Cidade.CidadeId);
            ctx.Enderecos.Add(endereco);
        }

        private static void AtualizarEndereco(DataContext ctx, Pessoa pessoa, EnderecoDTO enderecoDTO)
        {
            var endereco = GetEndereco(ctx, enderecoDTO.EnderecoId);
            endereco.Numero = enderecoDTO.Numero;
            endereco.Logradouro = enderecoDTO.Logradouro;
            endereco.CEP = enderecoDTO.CEP;
            endereco.TipoEndereco = enderecoDTO.TipoEndereco;
            endereco.Cidade = GetCidade(ctx, enderecoDTO.Cidade.CidadeId);
            endereco.Pessoa = pessoa;
            ctx.Entry(endereco).State = EntityState.Modified;
        }

        private static void ExcluirEndereco(DataContext ctx, EnderecoDTO endereco)
        {
            ctx.Enderecos.Remove(ctx.Set<Endereco>().Find(endereco.EnderecoId));
        }

        public static Endereco GetEndereco(DataContext ctx, int enderecoId)
        {
            return ctx.Set<Endereco>()
                .Include("Cidade")
                .Where(x => x.EnderecoId == enderecoId)
                .FirstOrDefault();
        }

        private static Cidade GetCidade(DataContext ctx, int cidadeId)
        {
            return ctx.Set<Cidade>().Where(x => x.CidadeId == cidadeId).First();
        }
    }
}
