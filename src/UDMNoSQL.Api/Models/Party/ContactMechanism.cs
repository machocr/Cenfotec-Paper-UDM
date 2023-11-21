using System;
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UDMNoSQL.Api.Models.Party
{
    [JsonDerivedType(typeof(PostalAddress), typeDiscriminator: "postalAddressClass")]
    [JsonDerivedType(typeof(TelecommunicationNumber), typeDiscriminator: "telecommunicationNumberClass")]
    [JsonDerivedType(typeof(ElectronicAddress), typeDiscriminator: "electronicAddressClass")]
    [BsonKnownTypes(typeof(PostalAddress), typeof(TelecommunicationNumber), typeof(ElectronicAddress))]
    public class ContactMechanism
	{
        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public ContactMechanismType Type { get; set; }
    }
}

