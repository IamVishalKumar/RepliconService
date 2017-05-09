using RepliconService.DataModel.Product;
using System.Collections.Generic;

namespace RepliconService.ServiceData.Interface
{
    public interface IProductRepository
    {
        IEnumerable<ProductDetail> GetProductDetails();
    }
}
