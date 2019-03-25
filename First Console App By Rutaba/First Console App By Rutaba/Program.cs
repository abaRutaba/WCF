using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Console_App_By_Rutaba
{
    class Program
    {
        static void Main(string[] args)
        {
             DataTable dt = new DataTable();

            try
            {

              
                    using (SPSite oSpSite = new SPSite("http://dev2016:69/NewSite/"))
                    {
                        SPWeb oSPWeb = oSpSite.OpenWeb();
                        SPList oSpList = oSPWeb.Lists.TryGetList("testlist");

                    //SPQuery query = new SPQuery();
                    //string NewsQuery = @" <Where>
                    //                              <And>
                    //                                 <Gt>
                    //                                    <FieldRef Name='ID' />
                    //                                    <Value Type='Counter'>1</Value>
                    //                                 </Gt>
                    //                                 <Lt>
                    //                                    <FieldRef Name='ID' />
                    //                                    <Value Type='Counter'>6</Value>
                    //                                 </Lt>
                    //                              </And>
                    //                           </Where>
                    //                           <OrderBy>
                    //                              <FieldRef Name='ID' Ascending='True' />
                    //                           </OrderBy>";
                    //query.Query = NewsQuery;

                    //SPListItemCollection ospcoll = oSpList.GetItems(query);

                    SPListItemCollection ospcoll = oSpList.Items;

                    dt = ospcoll.GetDataTable();

            // ftech 1st and last record by linq

          var abc = dt.AsEnumerable().OrderBy(x => x.Field<int>("ID")).First();

          var finalabc= dt.AsEnumerable().OrderByDescending(x => x.Field<int>("ID")).First();
                    DataTable dts = dt.Clone();

                    

                    dts.ImportRow(abc);
                    dts.ImportRow(finalabc);

                    //SPListItem updateItem = oSpList.GetItemById(4);
                    //updateItem["Title"] = "updated www";
                    //updateItem["name"] = "ww";
                    //updateItem["my country"] = "www";
                    //updateItem.Update();
                    //Console.WriteLine("Updated Successfully");
                    //Console.ReadLine();
                    //foreach (SPListItem  data in ospcoll)
                    //{
                    //    data["my country"] = "USA";
                    //    data.Update();
                    //}
                    // dt = ospcoll.GetDataTable();


                    //............... SELECT QUERY.....................
                    //dt = collListItems.GetDataTable();

                    // .............. INSERT QUERY.....................
                    SPListItem newItem = oSpList.Items.Add();
                    {
                        oSPWeb.AllowUnsafeUpdates = true;
                        newItem["Title"] = "R TITLE";
                        newItem["name"] = "RR";
                        newItem["my country"] = "RR";
                        newItem.Update();
                        Console.WriteLine("Successful Registration");
                        Console.ReadLine();
                    }
                    // .................DELETE QUERY....................
                    //SPListItem item = oSpList.GetItemById(5);
                    //item.Delete();
                    //Console.WriteLine("Deleted Successfully");
                    //Console.ReadLine();



                    ////............... UPDATE QUERY...................
                    //SPListItem updateItem = oSpList.GetItemById(4);
                    //updateItem["Title"] = "updated www";
                    //updateItem["name"] = "ww";
                    //updateItem["my country"] = "www";
                    //updateItem.Update();
                    //Console.WriteLine("Updated Successfully");
                    //Console.ReadLine();


                }



            }
            catch (Exception e)
            {
            }

        }
    }
}
