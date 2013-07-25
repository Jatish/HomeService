using HSG.Library;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Collections.Generic;

namespace HSG.Service.Catalog
{
    [ServiceContract]
    public interface ICatalogService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        string GetProducts();

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int SaveProduct(ProductDO objProduct);
    }
}
