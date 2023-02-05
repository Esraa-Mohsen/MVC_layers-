using Layers_DI.Models;
using Microsoft.EntityFrameworkCore;

namespace Layers_DI.Reposiotries
{
    public class EmployeeRepo : IEmployeeRepo

    {
        private CompanyDBContext db;

        public EmployeeRepo(CompanyDBContext dBContext)
        {
            this.db = dBContext;
        }

        public List<Employee> GetAll()
        {
            List<Employee> employees = db.Employees.ToList();
            return employees;
        }

        public Employee GetById(int id)
        {
            return db.Employees.SingleOrDefault(e => e.SSN == id);
        }

        public int Add(Employee employee)
        {
            try
            {
                db.Employees.Add(employee);
                return db.SaveChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int Edit(Employee employee)
        {
            try
            {
                Employee? oldEmployee = db.Employees.SingleOrDefault(e => e.SSN == employee.SSN);
                oldEmployee.Fname = employee.Fname;
                oldEmployee.Minit = employee.Minit;
                oldEmployee.Lname = employee.Lname;
                oldEmployee.Sex = employee.Sex;
                oldEmployee.Address = employee.Address;
                oldEmployee.Salary = employee.Salary;
                oldEmployee.BirthDate = employee.BirthDate;

                return db.SaveChanges();
            }
            catch (Exception e)
            {
                return -1;
            }

        }

        public int Delete(int id)
        {
            Employee employee = GetById(id);
            db.Employees.Remove(employee);
            return db.SaveChanges();
        }
    }
}
