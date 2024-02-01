using CRUDBasicCSharp.Models;
using MongoDB.Driver;

namespace CRUDBasicCSharp.Context
{
    public class PessoaContext
    {
        public List<Pessoa> ObterPessoas()
        {
            var colletionPessoas = Conn.GetCollection();
            var filter = Builders<Pessoa>.Filter.Empty;
            return colletionPessoas.Find(filter).ToList();
        }

        public bool Inserir(Pessoa pessoa)
        {
            try
            {
                var colletionPessoas = Conn.GetCollection();
                colletionPessoas.InsertOne(pessoa);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Pessoa ObterPessoa(string id)
        {
            var colletionPessoas = Conn.GetCollection();
            var filter = Builders<Pessoa>.Filter.Eq(x => x.Id, id);
            return colletionPessoas.Find(filter).FirstOrDefault();
        }

        public bool Atualizar(Pessoa pessoa)
        {
            try
            {
                var colletionPessoas = Conn.GetCollection();
                var filter = Builders<Pessoa>.Filter.Eq(x => x.Id, pessoa.Id);
                colletionPessoas.ReplaceOne(filter, pessoa);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Excluir(Pessoa pessoa)
        {
            try
            {
                var colletionPessoas = Conn.GetCollection();
                colletionPessoas.DeleteOne(x => x.Id == pessoa.Id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
