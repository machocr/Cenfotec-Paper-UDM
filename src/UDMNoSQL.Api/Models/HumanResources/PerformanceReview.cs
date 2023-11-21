using System;
namespace UDMNoSQL.Api.Models.HumanResources
{
	public class PerformanceReview
	{
        public string ManagerPartyId { get; set; }

        public Paycheck Paycheck { get; set; }

        public PayHistory PayHistory { get; set; }

        public string PositionId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public string Comments { get; set; }

        public List<PerformanceReviewItem> ItemList { get; set; }
    }
}

