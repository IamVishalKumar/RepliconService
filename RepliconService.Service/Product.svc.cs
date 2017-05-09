using RepliconService.DataModel.Product;
using RepliconService.ServiceManager.Interface;
using System.Collections.Generic;

namespace RepliconService.Service
{
   public class Product : IProduct
    {
        IProductManager _productManager;
        public Product(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public IEnumerable<ProductDetail> GetProductDetails()
        {
            return _productManager.GetProductDetails();
            
        }
        
    }
}
