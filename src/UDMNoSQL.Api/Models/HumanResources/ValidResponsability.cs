using System;
namespace UDMNoSQL.Api.Models.HumanResources
{
	public class ValidResponsability
	{
        public string TypeId { get; set; }

        public ResponsabilityType Type { get; }

        public string PositionTypeId { get; set; }

        public PositionType PositionType { get; }

        public DateTime FromDate { get; set; }

        public DateTime? ThruDate { get; set; }
    }
}

