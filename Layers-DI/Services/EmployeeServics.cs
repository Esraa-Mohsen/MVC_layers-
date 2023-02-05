using Layers_DI.Models;
using Layers_DI.Reposiotries;
using Layers_DI.ViewModels;

namespace Layers_DI.Services
{
    public class EmployeeServics : IEmployeeServics
    {
        private readonly IEmployeeRepo employeeRepo;

        //bissens layer 
        //create object from reposiotrie


        public EmployeeServics(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }
        //getall
        public List<EmployeeVM> GetAll()
        {
            List<Employee> employees = employeeRepo.GetAll();
            List<EmployeeVM> employeeVMs = new List<EmployeeVM>();
            foreach (var item in employees)
            {
                employeeVMs.Add(new EmployeeVM()
                {
                    SSN = item.SSN,
                    Fname = item.Fname,
                    Lname = item.Lname,
                    Minit = item.Minit,
                    Sex = item.Sex,
                    Address = item.Address,
                    Salary = item.Salary,
                    BirthDate = item.BirthDate,

                });
            }
            return employeeVMs;

        }

        public EmployeeVM GetById(int id)
        {
            Employee employee = employeeRepo.GetById(id);
            EmployeeVM employeeVM = new EmployeeVM()
            {
                SSN = employee.SSN,
                Fname = employee.Fname,
                Lname = employee.Lname,
                Minit = employee.Minit,
                Sex = employee.Sex,
                Address = employee.Address,
                Salary = employee.Salary,
                BirthDate = employee.BirthDate,


            };
            return employeeVM;
        }
        public int Add(EmployeeVM employeeVM)
        {

            Employee employee = new Employee()
            {
                SSN = employeeVM.SSN,
                Fname = employeeVM.Fname,
                Lname = employeeVM.Lname,
                Minit = employeeVM.Minit,
                Salary = employeeVM.Salary,
                Sex = employeeVM.Sex,
                Address = employeeVM.Address,
                deptId = employeeVM.deptId,
                BirthDate = employeeVM.BirthDate
            };

            return employeeRepo.Add(employee);

        }

        public int Edit(EmployeeVM employeeVM)
        {

            Employee employee = new Employee()
            {
                SSN = employeeVM.SSN,
                Fname = employeeVM.Fname,
                Lname = employeeVM.Lname,
                Minit = employeeVM.Minit,
                Salary = employeeVM.Salary,
                Sex = employeeVM.Sex,
                Address = employeeVM.Address,
                deptId = employeeVM.deptId,
                BirthDate = employeeVM.BirthDate
            };

            return employeeRepo.Add(employee);

        }
        public int Delete(int id)
        {
            return employeeRepo.Delete(id);

        }
    }
}
