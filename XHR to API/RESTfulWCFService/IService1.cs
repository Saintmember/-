using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
namespace RESTfulWCFService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped,
        UriTemplate = "/DbClient/UsersCount",
        ResponseFormat = WebMessageFormat.Json)]
        int GetUsersCount();
        [OperationContract]
        [WebInvoke(UriTemplate = "/DbClient/AddUser",
            Method = "POST",
        BodyStyle = WebMessageBodyStyle.WrappedRequest,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string GetUser(User user);
    }
}