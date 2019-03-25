using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Grid_View_Example.ServiceReference1;

namespace Grid_View_Example
{
    public partial class GridForm : System.Web.UI.Page
    {
        CRUD_SPClient client = null;
        protected void Page_Load(object sender, EventArgs e)
        {

      
       
                if (!this.IsPostBack)
            {
                client = new CRUD_SPClient();

                var abc = client.DoWork().ToList();// DoWork() is select query
                client.Close();
                this.BindGrid(abc);
                }
        }

        private void BindGrid(List<testlistmodeldisplayname> obj)
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Resources_CRUD"))
                {
                    cmd.Parameters.AddWithValue("@Action", "SELECT");
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = obj;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        protected void Insert(object sender, EventArgs e)
        {
            CRUD_SPClient client = new CRUD_SPClient();

            var abc = client.DoWork().ToList();

            client.Close();
            string name = txtName.Text;
            string country = txtCountry.Text;
            //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    using (SqlCommand cmd = new SqlCommand("Resources_CRUD"))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@Action", "INSERT");
            //        cmd.Parameters.AddWithValue("@Name", name);
            //        cmd.Parameters.AddWithValue("@Country", country);
            //        cmd.Connection = con;
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //    }
            //}

            client = new CRUD_SPClient();

            if (client.Insert(name,country))
            {
                this.BindGrid(client.DoWork().ToList());
            }

            client.Close();

        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
         

            client = new CRUD_SPClient();

            this.BindGrid(client.DoWork().ToList());

            client.Close();

        }

        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {
         
            client = new CRUD_SPClient();

            GridView1.EditIndex = -1;
            this.BindGrid(client.DoWork().ToList());
            
            client.Close();
        }

        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int ResourcesId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            string name = (row.FindControl("txtName") as TextBox).Text;
            string country = (row.FindControl("txtCountry") as TextBox).Text;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    using (SqlCommand cmd = new SqlCommand("Resources_CRUD"))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@Action", "UPDATE");
            //        cmd.Parameters.AddWithValue("@ResourcesId", ResourcesId);
            //        cmd.Parameters.AddWithValue("@Name", name);
            //        cmd.Parameters.AddWithValue("@Country", country);
            //        cmd.Connection = con;
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //    }
            //}

            client = new CRUD_SPClient();

            if (client.Update(ResourcesId, name, country))
            {
                GridView1.EditIndex = -1;
                this.BindGrid(client.DoWork().ToList());
              
            }

            client.Close();
 
         //   this.BindGrid();
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != GridView1.EditIndex)
            {
                (e.Row.Cells[2].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";
                //2 indexed column py jao or 2nd event i.e. delete ko link button treat kro or os py jb click ho to confirm kro.
            }
        }

        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ResourcesId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    using (SqlCommand cmd = new SqlCommand("Resources_CRUD"))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@Action", "DELETE");
            //        cmd.Parameters.AddWithValue("@ResourcesId", ResourcesId);
            //        cmd.Connection = con;
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //    }
            //}


            client = new CRUD_SPClient();

            if (client.Delete(ResourcesId))
            {
                       this.BindGrid(client.DoWork().ToList());
            }

            client.Close();
            //  this.BindGrid();
        }
    } }