using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public Employee GetEmployee(Guid companyId, Guid employeeId, bool trackChanges)
        {
            var employee = FindByCondition(e => e.CompanyId.Equals(companyId) && e.Id.Equals(employeeId), trackChanges).SingleOrDefault();
            return employee;    
        }

        public IEnumerable<Employee> GetEmployees(Guid companyId, bool trackChanges)
        {
            var employees = FindByCondition(e => e.CompanyId.Equals(companyId), trackChanges).OrderBy(e=> e.Name).ToList();
            return employees;   
        }
    }
}
