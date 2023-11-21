using System;
namespace UDMNoSQL.Api.Models.HumanResources
{
	public class Position
	{
        public string PositionId { get; set; }

        public DateTime EstimatedFromDate { get; set; }

        public DateTime EstimatedToDate { get; set; }

        public bool SalaryFlag { get; set; }

        public bool ExemptFlag { get; set; }

        public bool FulltimeFlag { get; set; }

        public bool TemporaryFlag { get; set; }

        public DateTime ActualFromDate { get; set; }

        public DateTime ActualToDate { get; set; }


        public string TypeId { get; set; }

        public PositionType Type { get; }

        public string BudgetId { get; set; }

        public int BudgetItemSeqId { get; set; }

        public BudgetItem BudgetItem { get; }

        public List<PositionResponsability> PositionResponsabilyList { get; set; }
    }
}

