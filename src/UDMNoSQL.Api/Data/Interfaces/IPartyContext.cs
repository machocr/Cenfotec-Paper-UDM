using System;
using MongoDB.Driver;
using UDMNoSQL.Api.Models;

namespace UDMNoSQL.Api.Data.Interfaces
{
	public interface IPartyContext<T>
    {
        IMongoCollection<T> PartyCollection { get; }
    }
}
