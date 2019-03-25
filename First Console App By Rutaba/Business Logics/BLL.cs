using Business_Logics.Model;
using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logics
{
    public class BLL
    {

        public static bool Insert( string name, string country)
        {

            // Insert query

            try
            {

                SPSecurity.RunWithElevatedPrivileges(delegate ()
                {
                    using (SPSite oSpSite = new SPSite("http://dev2016:69/NewSite/"))
                    {
                        SPWeb oSPWeb = oSpSite.OpenWeb();
                        SPList oSpList = oSPWeb.Lists.TryGetList("testlist");
                        SPListItemCollection ospcoll = oSpList.Items;
                        // table = ospcoll.GetDataTable();

                        SPListItem newItem = oSpList.Items.Add();
                        {
                            oSPWeb.AllowUnsafeUpdates = true;
                            newItem["Title"] = "Demo";
                            newItem["name"] = name;
                            newItem["my country"] = country;
                            newItem.Update();
                            Console.WriteLine("Successful Registration");
                        }
                    }
                });
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static List<testlistmodel.displayname> callme()
        {
            List<testlistmodel.displayname> testlistmodelobj = new List<testlistmodel.displayname>();
            DataTable table = new DataTable();

            try
            {

                SPSecurity.RunWithElevatedPrivileges(delegate ()
               {
                   using (SPSite oSpSite = new SPSite("http://dev2016:69/NewSite/"))
                   {
                       SPWeb oSPWeb = oSpSite.OpenWeb();
                       SPList oSpList = oSPWeb.Lists.TryGetList("testlist");

                       SPListItemCollection ospcoll = oSpList.Items;
                       table = ospcoll.GetDataTable();


                        // Select query
                        // following is working like for each loop

                        testlistmodelobj = table.AsEnumerable().Select(dr => new testlistmodel.displayname
                       {
                           ID = Convert.ToInt32(dr.Field<Int32>("ID")),
                           Created = dr.Field<DateTime>(testlistmodel.internalnames.Created),
                           my_country = dr.Field<string>(testlistmodel.internalnames.my_country),
                           name = dr.Field<string>(testlistmodel.internalnames.name),
                           Title = dr.Field<string>(testlistmodel.internalnames.Title)

                       }).ToList();



                   }
               });
                return testlistmodelobj;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public static bool Delete(int id)
        {
            try
            {

                SPSecurity.RunWithElevatedPrivileges(delegate ()
                {
                    using (SPSite oSpSite = new SPSite("http://dev2016:69/NewSite/"))
                    {

                        SPWeb oSPWeb = oSpSite.OpenWeb();
                        SPList oSpList = oSPWeb.Lists.TryGetList("testlist");
                        SPListItem item = oSpList.GetItemById(id);
                        item.Delete();
                        //Console.WriteLine("Deleted Successfully");
                        //Console.ReadLine();
                    }
                });
                return true;
            }
            catch (Exception e)
            {
                return false;

            }
        }


        public static bool Update( int id, string name, string country)
        {
            try
            {

                SPSecurity.RunWithElevatedPrivileges(delegate ()
                {
                    using (SPSite oSpSite = new SPSite("http://dev2016:69/NewSite/"))
                    {
                        ////............... UPDATE QUERY...................
                        SPWeb oSPWeb = oSpSite.OpenWeb();
                        SPList oSpList = oSPWeb.Lists.TryGetList("testlist");
                        
                        SPListItem updateItem = oSpList.GetItemById(id);
                        updateItem["Title"] = "Demo";
                        updateItem["name"] = name;
                        updateItem["my country"] = country;
                        updateItem.Update();
                        //Console.WriteLine("Updated Successfully");
                        //Console.ReadLine();

                    }
                });
                return true;
            }
            catch (Exception e)

            { return false; }
        }
    }
}
