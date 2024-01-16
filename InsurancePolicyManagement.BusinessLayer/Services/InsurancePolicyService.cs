using InsurancePolicyManagement.BusinessLayer.Interfaces;
using InsurancePolicyManagement.BusinessLayer.Services.Repository;
using InsurancePolicyManagement.BusinessLayer.ViewModels;
using InsurancePolicyManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePolicyManagement.BusinessLayer.Services
{
    public class InsurancePolicyService : IInsurancePolicyService
    {
        private readonly IInsurancePolicyRepository _insurancePolicyRepository;

        public InsurancePolicyService(IInsurancePolicyRepository insurancePolicyRepository)
        {
            _insurancePolicyRepository = insurancePolicyRepository;
        }

        public async Task<InsurancePolicy> CreateInsurancePolicy(InsurancePolicy insurancePolicy)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteInsurancePolicyById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<InsurancePolicy> GetAllInsurancePolicies()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<InsurancePolicy> GetInsurancePolicyById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<InsurancePolicy> UpdateInsurancePolicy(InsurancePolicyViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}