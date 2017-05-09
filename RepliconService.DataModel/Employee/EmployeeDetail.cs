using System.Runtime.Serialization;

namespace RepliconService.DataModel.Employee
{
    [DataContract]
    public class EmployeeDetail
    {
        [DataMember]
        public string EmployeeName { get; set; }

        [DataMember]
        public string EmployeeType { get; set; }

        [DataMember]
        public string Designation { get; set; }
    }
}
