using System;
namespace UDMNoSQL.Api.Models.HumanResources
{
	public class PositionType
	{
        public string PositionTypeId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int BenefirPercent { get; set; }

        public List<PositionTypeClass> PositionTypeClassList { get; set; } = new List<PositionTypeClass>();

        public List<PositionTypeRate> PositionTypeRateList { get; set; } = new List<PositionTypeRate>();
    }
}

