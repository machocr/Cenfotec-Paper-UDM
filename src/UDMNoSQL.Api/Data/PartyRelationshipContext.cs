using MongoDB.Driver;
using UDMNoSQL.Api.Data.Interfaces;
using UDMNoSQL.Api.Models.Party;

namespace UDMNoSQL.Api.Data
{
    public class PartyRelationshipContext : IPartyRelationshipContext
    {
        public PartyRelationshipContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            PartyRelationshipCollection = database.GetCollection<PartyRelationship>("PartyRelationship");
        }

        public IMongoCollection<PartyRelationship> PartyRelationshipCollection { get; }
    }
}
