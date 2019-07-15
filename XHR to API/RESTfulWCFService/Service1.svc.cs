using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
namespace RESTfulWCFService
{
    [AspNetCompatibilityRequirements(RequirementsMode
   = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {
        private readonly IDAL _dal = new EDAL();
        public int GetUsersCount()
        {
            return _dal.GetUsersCount();
        }
        public string GetUser(User user)
        {
            _dal.AddUser(user);
            return "";
        }
    }
}