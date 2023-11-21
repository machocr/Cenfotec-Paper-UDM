using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Converters;
using UDMNoSQL.Api.Models.HumanResources;

namespace UDMNoSQL.Api.Models
{
    [JsonDerivedType(typeof(Employment), typeDiscriminator: "employmentClass")]
    [BsonKnownTypes(typeof(Employment))]
    public abstract class Relationship
	{
		public DateTime FromDate { get; set; }

        public DateTime? ThruDate { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public RoleType FromRoleType { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public RoleType ToRoleType { get; set; }
    }
}

