using DataViewModel;
using Services.Case;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RCMSWebAPI.Models
{
    public class UserMasterRepository : IDisposable
    {
       
        // SECURITY_DBEntities it is your context class
        SECURITY_DBEntities context = new SECURITY_DBEntities();
        //This method is used to check and validate the user credentials
        public UserMaster ValidateUser(string username, string password)
        {
            return context.UserMasters.FirstOrDefault(user =>
            user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.Password == password);
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}