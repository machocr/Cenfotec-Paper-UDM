using MongoDB.Driver;
using UDMNoSQL.Api.Data.Interfaces;
using UDMNoSQL.Api.Models.Party;

namespace UDMNoSQL.Api.Data
{
    public class PartyContext<T> : IPartyContext<T>
        where T : Party
    {
        public PartyContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            PartyCollection = database.GetCollection<T>("Party");
        }

        public IMongoCollection<T> PartyCollection { get; }
    }
}
