using Business_Logics.Model;
using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace My_WCF_Application
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICRUD_SP" in both code and config file together.
    [ServiceContract]
    public interface ICRUD_SP
    {
        [OperationContract]
        List<testlistmodel.displayname> DoWork();// select

        [OperationContract]
        bool Insert(string name, string country);// insert

        [OperationContract]
        bool Update(int id, string name, string country);// update

        [OperationContract]
  bool Delete(int id);// delete
    }
}
