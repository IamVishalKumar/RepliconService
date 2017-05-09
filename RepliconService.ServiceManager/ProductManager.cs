using RepliconService.DataModel.Product;
using RepliconService.ServiceData.Interface;
using RepliconService.ServiceManager.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepliconService.ServiceManager
{
    public class ProductManager : IProductManager
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<ProductDetail> GetProductDetails()
        {
            return _productRepository.GetProductDetails();
        }
    }
}
