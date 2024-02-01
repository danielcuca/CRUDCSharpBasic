using CRUDBasicCSharp.Context;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CRUDBasicCSharp.Models
{
    public class Pessoa
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string? CpfOuCnpj { get; set; }

        private PessoaContext _pessoaContext = new PessoaContext();

        public List<Pessoa> ObterPessoas()
        {
            return _pessoaContext.ObterPessoas();
        }

        public bool Inserir(Pessoa pessoa)
        {
            return _pessoaContext.Inserir(pessoa);
        }

        public Pessoa ObterPessoa(string id)
        {
            return _pessoaContext.ObterPessoa(id);
        }

        public bool Atualizar(Pessoa pessoa)
        {
            return _pessoaContext.Atualizar(pessoa);
        }
        public Pessoa Visualizar(string id)
        {
            return _pessoaContext.ObterPessoa(id);
        }
        public bool Excluir(Pessoa pessoa)
        {
            return _pessoaContext.Excluir(pessoa);
        }
    }
}
