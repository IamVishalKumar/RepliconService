using Ninject.Modules;
using RepliconService.ServiceData.Interface;
using RepliconService.ServiceData.Repository;
using RepliconService.ServiceManager;
using RepliconService.ServiceManager.Interface;

namespace RepliconService.Infrastructure.DependencyResolution
{
    public class EmployeeModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEmployeeManager>().To<EmployeeManager>();
            Bind<IEmployeeRepository>().To<EmployeeRepository>();
        }
    }
}
