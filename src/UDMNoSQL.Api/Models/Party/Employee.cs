using System;
using System.Text.Json.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace UDMNoSQL.Api.Models.Party
{
    [BsonDiscriminator("employeeClass")]
    public class Employee : PartyRole
	{
		public Employee()
		{
			this.Type = RoleType.Employee;
		}
	}
}

