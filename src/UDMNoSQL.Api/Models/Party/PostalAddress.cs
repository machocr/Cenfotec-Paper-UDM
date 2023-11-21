using System;
using MongoDB.Bson.Serialization.Attributes;

namespace UDMNoSQL.Api.Models.Party
{
    [BsonDiscriminator("postalAddressClass")]
    public class PostalAddress : ContactMechanism
	{
        public string Country { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string PostalCode { get; set; } = string.Empty;

        public string Address1 { get; set; } = string.Empty;

        public string Address2 { get; set; } = string.Empty;

        public string Directions { get; set; } = string.Empty;
    }
}

