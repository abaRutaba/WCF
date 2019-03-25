using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using Microsoft.SharePoint;
using Business_Logics;
using Business_Logics.Model;

namespace My_WCF_Application
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CRUD_SP" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CRUD SP.svc or CRUD SP.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(
       RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CRUD_SP : ICRUD_SP
    {
        public List<testlistmodel.displayname> DoWork()// Interface Method
        {
            return BLL.callme();
        }
        public bool Insert(string name, string country)// Interface Method
        {


            return BLL.Insert(name, country);
        }
        public bool Update(int id, string name, string country)// Interface Method
        {

            return BLL.Update(id, name, country);
        }
        public bool Delete(int id)// Interface Method
        {
            
            return BLL.Delete(id);
        }
    }
}
