using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace UDMNoSQL.Api.Models
{
	public class Type
	{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string TypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}

