using DataAccess;
using Domain.DTO;
using Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System;

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
            foreach(var enderecoDTO in listEnderecoDTO) {
                SalvarEndereco(ctx, pessoa, enderecoDTO);
            }
            foreach(var foneDTO in listTelefoneDTO) {
                SalvarTelefone(ctx, pessoa, foneDTO);
            }
            ctx.SaveChanges();
        }

        public static void Atualizar(DataContext ctx, Fornecedor fornecedor, List<EnderecoDTO> listEnderecoDTO, List<TelefoneDTO> listTelefoneDTO)
        {
            foreach(var enderecoDTO in listEnderecoDTO) {

                if(enderecoDTO.IsDeleted) {
                    ExcluirEndereco(ctx, enderecoDTO);
                }
                else if(enderecoDTO.IsPersisted) {
                    AtualizarEndereco(ctx, fornecedor.Pessoa, enderecoDTO);
                }
                else {
                    SalvarEndereco(ctx, fornecedor.Pessoa, enderecoDTO);
                }
            }

            foreach(var telefoneoDTO in listTelefoneDTO) {

                if(telefoneoDTO.IsDeleted) {
                    ExcluirTelefone(ctx, telefoneoDTO);
                }
                else if(telefoneoDTO.IsPersisted) {
                    AtualizarTelefone(ctx, fornecedor.Pessoa, telefoneoDTO);
                }
                else {
                    SalvarTelefone(ctx, fornecedor.Pessoa, telefoneoDTO);
                }
            }
            ctx.Entry(fornecedor.Pessoa).State = EntityState.Modified;
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


        public static List<EnderecoDTO> GetAllEnderecos(DataContext ctx, int FornecedorId)
        {
            var pessoaId = ctx.Set<Fornecedor>().Where(x => x.FornecedorId == FornecedorId).AsNoTracking().Select(p => p.Pessoa.PessoaId).SingleOrDefault();
            return ctx.Set<Endereco>()
                .Include("Cidade")
                .Include("Pessoa")
                .Where(x => x.Pessoa.PessoaId == pessoaId)
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

        public static void ExcluirEndereco(DataContext ctx, EnderecoDTO endereco)
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

        public static Cidade GetCidade(DataContext ctx, int cidadeId)
        {
            return ctx.Set<Cidade>().Where(x => x.CidadeId == cidadeId).First();
        }


        public static List<TelefoneDTO> GetAllFones(DataContext ctx, int FornecedorId)
        {
            var pessoaId = ctx.Set<Fornecedor>().Where(x => x.FornecedorId == FornecedorId).AsNoTracking().Select(p => p.Pessoa.PessoaId).SingleOrDefault();
            return ctx.Set<Telefone>()
                .Include("Pessoa")
                .Where(x => x.Pessoa.PessoaId == pessoaId)
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

        public static void ExcluirTelefone(DataContext ctx, TelefoneDTO telefoneDTO)
        {
            ctx.Telefones.Remove(ctx.Set<Telefone>().Find(telefoneDTO.TelefoneId));
        }
    }
}
