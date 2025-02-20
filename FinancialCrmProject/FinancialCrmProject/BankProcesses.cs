using System;

namespace FinancialCrmDb.Models
{

    public partial class BankProcesses
    {
        public int BankProcessId { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> ProcessDate { get; set; }
        public string ProcessType { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> BankId { get; set; }

        public virtual Bank Banks { get; set; }
    }
}
//public class BankProcesses
//    {
//    }
