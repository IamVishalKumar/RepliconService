using System.Collections.Generic;
using RepliconService.ServiceManager.Interface;
using RepliconService.DataModel.Employee;

namespace RepliconService.Service
{
    public class Employee : IEmployee
    {
        IEmployeeManager _employeManager;
        public Employee(IEmployeeManager employeManager)
        {
            _employeManager = employeManager;
        }

        public IEnumerable<EmployeeDetail> GetEmployeeDetails()
        {
            return _employeManager.GetEmployeeDetails();
        }
    }
}
