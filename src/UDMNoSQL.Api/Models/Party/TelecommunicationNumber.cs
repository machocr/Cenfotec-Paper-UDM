using System;
using MongoDB.Bson.Serialization.Attributes;

namespace UDMNoSQL.Api.Models.Party
{
    [BsonDiscriminator("telecommunicationNumberClass")]
    public class TelecommunicationNumber : ContactMechanism
	{
        public string AreaCode { get; set; } = string.Empty;

        public string ContactNumber { get; set; } = string.Empty;

        public string CountryCode { get; set; } = string.Empty;
    }
}

