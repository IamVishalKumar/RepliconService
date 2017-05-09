using RepliconService.DataModel.Product;
using System.Collections.Generic;

namespace RepliconService.ServiceManager.Interface
{
    public interface IProductManager
    {
        IEnumerable<ProductDetail> GetProductDetails();
    }
}
