using InsurancePolicyManagement.BusinessLayer.ViewModels;
using InsurancePolicyManagement.DataLayer;
using InsurancePolicyManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePolicyManagement.BusinessLayer.Services.Repository
{
    public class InsurancePolicyRepository : IInsurancePolicyRepository
    {
        private readonly InsuranceDbContext _dbContext;
        public InsurancePolicyRepository(InsuranceDbContext dbContext)
        {
            _dbContext = dbContext;
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