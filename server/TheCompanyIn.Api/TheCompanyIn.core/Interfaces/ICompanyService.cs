using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheCompanyIn.Core.ViewModels;

namespace TheCompanyIn.Core.Interfaces
{
    public interface ICompanyService
    {
        Task<T> GetCompanyInfoAsync<T>(string id);
        Task<T> GetCompanyMetadataAsync<T>(string companyDomain);

    }
}
