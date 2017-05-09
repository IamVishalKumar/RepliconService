using RepliconService.DataModel.Employee;
using System.Collections.Generic;

namespace RepliconService.ServiceData.Interface
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeDetail> GetEmployeeDetails();
    }
}
