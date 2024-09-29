using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string WorkEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkPhone { get; set; }
        public DateTime HireDate { get; set; }
        public string JobId { get; set; }  // Can include job titles like 'Software Engineer', 'Project Manager' etc.
        public decimal Salary { get; set; }
        public string Role { get; set; }  // Define the role within the company
        public string EmploymentType { get; set; }  // Full-time, Part-time, Contractor
        public string WorkSituation { get; set; }  // Remote, In-office, Hybrid
        public DateTime? StartDate { get; set; }  // Optional field for tracking when they begin work
        public string LinkedIn { get; set; }  // Optional, for professional networking purposes
    }
}
