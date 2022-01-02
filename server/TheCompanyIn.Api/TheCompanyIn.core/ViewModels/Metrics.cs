using System;
using System.Collections.Generic;
using System.Text;

namespace TheCompanyIn.Core.ViewModels
{
    public class Metrics
    {
        public int? alexaUsRank { get; set; }
        public int? alexaGlobalRank { get; set; }
        public int? employees { get; set; }
        public string employeesRange { get; set; }
        public long? marketCap { get; set; }
        public object raised { get; set; }
        public long? annualRevenue { get; set; }
        public string estimatedAnnualRevenue { get; set; }
        public int? fiscalYearEnd { get; set; }
    }
}
