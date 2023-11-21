using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UDMNoSQL.Api.Models.Party
{
    [JsonDerivedType(typeof(Person), typeDiscriminator: "personClass")]
    [JsonDerivedType(typeof(Organization), typeDiscriminator: "organizationClass")]
    [BsonKnownTypes(typeof(Person), typeof(Organization))]
    public abstract class Party
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
        public string PartyId { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public PartyType Type { get; set; }

        public List<PartyRole> RoleList {get; set;} = new List<PartyRole>();

        public List<PartyContactMechanism> ContactMechanismList { get; set; } = new List<PartyContactMechanism>();

        public bool HasRole(RoleType roleType)
        {
            return RoleList.Exists(x => x.Type == roleType);
        }

    }
}

