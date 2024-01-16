using InsurancePolicyManagement.BusinessLayer.Interfaces;
using InsurancePolicyManagement.BusinessLayer.ViewModels;
using InsurancePolicyManagement.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InsurancePolicyManagement.Controllers
{
    [ApiController]
    public class InsurancePolicyController : ControllerBase
    {
        private readonly IInsurancePolicyService _insurancePolicyService;
        public InsurancePolicyController(IInsurancePolicyService insurancePolicyService)
        {
            _insurancePolicyService = insurancePolicyService;
        }

        [HttpPost]
        [Route("create-policy")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateInsurancePolicy([FromBody] InsurancePolicy model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("update-policy")]
        public async Task<IActionResult> UpdateInsurancePolicy([FromBody] InsurancePolicyViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("delete-policy")]
        public async Task<IActionResult> DeleteInsurancePolicy(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-policy-by-id")]
        public async Task<IActionResult> GetInsurancePolicyById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("get-all-policies")]
        public async Task<IEnumerable<InsurancePolicy>> GetAllPolicies()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}