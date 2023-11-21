using System;
using System.Text.Json.Serialization;

namespace UDMNoSQL.Api.Models.Party
{
    public class PartyContactMechanism
	{
        public ContactMechanism ContactMechanism { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public bool NonSolicitationIndicator { get; set; }

        public string Comment { get; set; } = string.Empty;
    }
}

