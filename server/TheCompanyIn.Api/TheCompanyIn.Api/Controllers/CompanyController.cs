using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheCompanyIn.Core.Interfaces;
using TheCompanyIn.Core.ViewModels;

namespace TheCompanyIn.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : ControllerBase
    {

        private readonly ILogger<CompanyController> _logger;
        private readonly ICompanyService _companyService;

        public CompanyController(
            ILogger<CompanyController> logger,
            ICompanyService companyService
            )
        {
            _logger = logger;
            _companyService = companyService;
        }

        [HttpGet("metadata")]
        public async Task<IActionResult> GetCompanyMetadata(string companyDomain)
        {
            try
            {
                var companyMetadata = await _companyService.GetCompanyMetadataAsync<CompanyMetadata>(companyDomain);
                return Ok(companyMetadata);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "CompanyMetadata");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }   

        [HttpGet("info")]
        public async Task<IActionResult> GetCompanyInfo(string id)
        {
            try
            {
                var companyInfo = await _companyService.GetCompanyInfoAsync<CompanyInfo>(id);
                return Ok(companyInfo);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetCompanyInfo");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
