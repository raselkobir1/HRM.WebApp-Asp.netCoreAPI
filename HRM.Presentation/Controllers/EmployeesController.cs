﻿using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace HRM.Presentation.Controllers
{
    [Route("api/companies/{companyId}/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public EmployeesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager; 
        }

        [HttpGet]
        public IActionResult GetEmployeesForCompany(Guid companyId)
        {
            var employees = _serviceManager.EmployeeService.GetEmployees(companyId, trackChanges:false);
            return Ok(employees);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetEmployeeForCompany(Guid companyId, Guid id)
        {
           var employee = _serviceManager.EmployeeService.GetEmployee(companyId, id, false);
            return Ok(employee);
        }

    }
}
