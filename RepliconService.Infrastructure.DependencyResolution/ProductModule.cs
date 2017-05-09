using Ninject.Modules;
using RepliconService.ServiceData.Interface;
using RepliconService.ServiceData.Repository;
using RepliconService.ServiceManager;
using RepliconService.ServiceManager.Interface;

namespace RepliconService.Infrastructure.DependencyResolution
{
    public class ProductModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductManager>().To<ProductManager>();
            Bind<IProductRepository>().To<ProductRepository>();
        }
    }
}
