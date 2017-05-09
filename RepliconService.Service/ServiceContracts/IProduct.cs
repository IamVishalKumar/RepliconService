using RepliconService.DataModel.Product;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RepliconService.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProduct" in both code and config file together.
    [ServiceContract]
    public interface IProduct
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<ProductDetail> GetProductDetails();
    }


}
