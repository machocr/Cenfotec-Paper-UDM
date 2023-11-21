using System;
using MongoDB.Driver;
using UDMNoSQL.Api.Data.Interfaces;
using UDMNoSQL.Api.Models;
using UDMNoSQL.Api.Models.Party;
using UDMNoSQL.Api.Repositories.Interfaces;

namespace UDMNoSQL.Api.Repositories
{
	public class PartyRepository<T> : IPartyRepository<T>
        where T : Party
    {
        private readonly IPartyContext<T> _context;

        public PartyRepository(IPartyContext<T> context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<T>> GetPartyList()
        {
            var type = PartyType.Person;
            if (typeof(T) == typeof(Organization)) type = PartyType.Organization;

            return (IEnumerable<T>)await _context
                            .PartyCollection
                            .Find(p => p.Type == type)
                            .ToListAsync();
        }

        public async Task<T> GetParty(string partyId)
        {
            return (T)await _context
                           .PartyCollection
                           .Find(p => p.PartyId == partyId)
                           .FirstOrDefaultAsync();
        }

        public async Task CreateParty(T party)
        {
            await _context.PartyCollection.InsertOneAsync(party);
        }

        public async Task<bool> UpdateParty(T party)
        {
            var updateResult = await _context
                                        .PartyCollection
                                        .ReplaceOneAsync(filter: g => g.PartyId == party.PartyId, replacement: party);

            return updateResult.IsAcknowledged
                    && updateResult.ModifiedCount > 0;
        }

        public async Task<bool> DeleteParty(string partyId)
        {
            FilterDefinition<T> filter = Builders<T>.Filter.Eq(p => p.PartyId, partyId);

            DeleteResult deleteResult = await _context
                                                .PartyCollection
                                                .DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;
        }
    }
}
