using System;
using System.Collections.Generic;
using System.Text;

namespace TheCompanyIn.Core.ViewModels
{

    public class CompanyInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string legalName { get; set; }
        public string domain { get; set; }
        public Category category { get; set; }
        public string description { get; set; }
        public int? foundedYear { get; set; }
        public string location { get; set; }
        public string timeZone { get; set; }
        public int? utcOffset { get; set; }
        public string logo { get; set; }
        public bool emailProvider { get; set; }
        public string type { get; set; }
        public string ticker { get; set; }
        public string phone { get; set; }
        public Metrics metrics { get; set; }
        public DateTime indexedAt { get; set; }
        public List<string> tech { get; set; }
        public List<string> techCategories { get; set; }
    }
}
