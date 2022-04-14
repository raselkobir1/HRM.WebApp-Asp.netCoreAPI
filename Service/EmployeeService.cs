using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class EmployeeService : IEmployeeService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;
        public EmployeeService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

        public IEnumerable<EmployeeDto> GetEmployees(Guid companyId, bool trackChanges)
        {
            var company = _repositoryManager.Company.GetCompany(companyId, trackChanges);
            if (company is null)
                throw new CompanyNotFoundException(companyId);

            var employeesFromDb = _repositoryManager.Employee.GetEmployees(companyId, trackChanges);
            var employeesDto = _mapper.Map<IEnumerable<EmployeeDto>>(employeesFromDb);
            return employeesDto;
        }
    }
}
