using RepliconService.DataModel.Product;
using RepliconService.ServiceData.Interface;
using System.Collections.Generic;

namespace RepliconService.ServiceData.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<ProductDetail> GetProductDetails()
        {
            IEnumerable<ProductDetail> list = new List<ProductDetail>()
            {
                new ProductDetail(){ Id=1, Name= "Puma Shoe", Description="Sport shoe - white color", Price=3000, Rating = "5 Star" },
                new ProductDetail(){ Id=2,Name= "Addidas Shoe", Description="Sport shoe - blue color", Price=4000, Rating = "5 Star" },
                new ProductDetail(){ Id=3,Name= "Reebok Shoe", Description="Casual shoe - white color", Price=8000, Rating = "3 Star" },
                new ProductDetail(){ Id=4,Name= "Nike Shoe", Description="Casual shoe - red color", Price=2200, Rating = "4 Star" },
                new ProductDetail(){ Id=5,Name= "Bata Shoe", Description="Leather shoe - black color", Price=1200, Rating = "4 Star" },
                new ProductDetail(){ Id=6,Name= "Looto Shoe", Description="Sport shoe - white color", Price=800, Rating = "3 Star" },
                new ProductDetail(){ Id=7,Name= "Fila Shoe", Description="Sport shoe - white color", Price=1700, Rating = "2 Star" }
            };
            return list;
        }
    }
}
