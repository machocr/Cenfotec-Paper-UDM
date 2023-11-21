using System;
using MongoDB.Bson.Serialization.Attributes;

namespace UDMNoSQL.Api.Models.Party
{
    [BsonDiscriminator("electronicAddressClass")]
    public class ElectronicAddress : ContactMechanism
	{
        public string ElectronicAddressString { get; set; } = "";
    }
}

