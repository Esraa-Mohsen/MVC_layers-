using Microsoft.AspNetCore.Mvc.Rendering;

namespace Layers_DI.ViewModels
{
    public class EmployeeVM
    {
        
        public int SSN { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Minit { get; set; }
        public string? Sex { get; set; }
        public string? Address { get; set; }
        public int? Salary { get; set; }
        public DateTime? BirthDate { get; set; }

        public int? SupervisorSSN { get; set; }
        public SelectList? Supervisors { get; set; }
        public int? deptId { get; set; }

    }
}
