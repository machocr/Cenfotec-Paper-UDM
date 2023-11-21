using System;
namespace UDMNoSQL.Api.Models.HumanResources
{
	public class PositionFulfillment
	{
        public DateTime FromDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public string Comment { get; set; }
    }
}

