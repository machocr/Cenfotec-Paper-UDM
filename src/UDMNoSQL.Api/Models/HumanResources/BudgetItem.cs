using System;
namespace UDMNoSQL.Api.Models.HumanResources
{
	public class BudgetItem
	{
        public string BudgetId { get; set; }

        public int BudgetItemSeqId { get; set; }

        public decimal Amount { get; set; }

        public string Purpose { get; set; }

        public string Justification { get; set; }
    }
}

