using CRUDBasicCSharp.Models;
using MongoDB.Driver;

namespace CRUDBasicCSharp.Context
{
    public class Conn
    {
        public static readonly string Server = "mongodb://localhost:27017"; 
        public static readonly string Database = "comercial";
        public static readonly string Collection = "pessoas";

        public static IMongoCollection<Pessoa> GetCollection()
        {
            var client = new MongoClient(Server);
            var database = client.GetDatabase(Database);
            var collection = database.GetCollection<Pessoa>(Collection);
            return collection;
        }
    }
}
