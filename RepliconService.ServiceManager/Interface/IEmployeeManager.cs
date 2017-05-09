using RepliconService.DataModel.Employee;
using System.Collections.Generic;

namespace RepliconService.ServiceManager.Interface
{
    public interface IEmployeeManager
    {
        IEnumerable<EmployeeDetail> GetEmployeeDetails();
    }
}
