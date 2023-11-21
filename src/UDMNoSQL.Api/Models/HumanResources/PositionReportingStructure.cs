using System;
namespace UDMNoSQL.Api.Models.HumanResources
{
	public class PositionReportingStructure
	{
        public string ManagerOfPositionId { get; set; }

        public string ReportingOfPositionId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public string Comment { get; set; }

        public bool PrimaryFlag { get; set; }
    }
}

