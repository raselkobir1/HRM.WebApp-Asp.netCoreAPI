using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Employee
    {
        [Column("EmployeeId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Employee name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Age is a required field.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Position is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Position is 20 characters.")]
        public string? Position { get; set; }

        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }
    }

    //public class Company
    //{
    //    public long Id { get; set; }
    //    public string Name { get; set; }
    //    public DateTime CreatedOn { get; set; }
    //    public DateTime ModifiedOn { get; set; }

    //}

    //public class Employee
    //{
    //    public long Id { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public long ManagerId { get; set; } 
    //    public DateTime CreatedOn { get; set; }
    //    public DateTime ModifiedOn { get; set; }
    //    public long CompanyId { get; set; } 
    //    public long DepartmentId { get; set; } 
    //    public long DesignationId { get; set; }  

    //}
}
