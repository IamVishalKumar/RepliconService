using RepliconService.DataModel.Employee;
using RepliconService.ServiceData.Interface;
using RepliconService.ServiceManager.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepliconService.ServiceManager
{
    public class EmployeeManager : IEmployeeManager
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<EmployeeDetail> GetEmployeeDetails()
        {
            return _employeeRepository.GetEmployeeDetails();
        }
    }
}
