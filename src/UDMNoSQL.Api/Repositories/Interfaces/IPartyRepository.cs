using System;
using UDMNoSQL.Api.Models;
using UDMNoSQL.Api.Models.Party;

namespace UDMNoSQL.Api.Repositories.Interfaces
{
	public interface IPartyRepository<T>
        where T : Party
    {
        Task<IEnumerable<T>> GetPartyList();
        Task<T> GetParty(string partyId);
        Task CreateParty(T party);
        Task<bool> UpdateParty(T party);
        Task<bool> DeleteParty(string partyId);
    }
}

