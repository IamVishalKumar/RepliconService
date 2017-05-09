using RepliconService.ServiceData.Interface;
using System.Collections.Generic;
using RepliconService.DataModel.Employee;

namespace RepliconService.ServiceData.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<EmployeeDetail> GetEmployeeDetails()
        {
            IEnumerable<EmployeeDetail> list = new List<EmployeeDetail>()
            {
                new EmployeeDetail(){ EmployeeName= "Vishal Kumar", EmployeeType="Full time", Designation="Senior Software Engineer" },
                new EmployeeDetail(){ EmployeeName= "Mohit Daga", EmployeeType="Full time", Designation="Architect" },
                new EmployeeDetail(){ EmployeeName= "Snehashish Giri", EmployeeType="Part time", Designation="Team Lead" },
                new EmployeeDetail(){ EmployeeName= "Vikram Khyadi", EmployeeType="Part time", Designation="Software Engineer" },
                new EmployeeDetail(){ EmployeeName= "Mitra Sharma", EmployeeType="Probation", Designation="Senior Software Engineer" },
                new EmployeeDetail(){ EmployeeName= "Shubhra Swarup", EmployeeType="Probation", Designation="Senior Software Engineer" },
                new EmployeeDetail(){ EmployeeName= "Ashish Sharam", EmployeeType="Probation", Designation="Software Engineer" }
            };
            return list;
        }
    }
}
