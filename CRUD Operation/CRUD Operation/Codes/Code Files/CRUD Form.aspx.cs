using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Operation
{
    public partial class CRUD_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*connecting sql server and retrieving data from database in dropdown list
             
            String CS=ConfigurationManager.ConnectionStrings["CRUDConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select Teacher from STUDENT_DETAILS", con);
                con.Open();
                DropDownList1.DataSource = cmd.ExecuteReader();
                DropDownList1.DataTextField = "Teacher";
                DropDownList1.DataBind();
            }   
            */

            //retreiving data from XML into dropdown list

            if (!IsPostBack)
            {

                DataSet DS = new DataSet();

                //Server.mappath is used to return physical path for the given virtual path

                DS.ReadXml(Server.MapPath("~/Data/XML Files/Teachers.xml"));

                DropDownList1.DataSource = DS;
                DropDownList1.DataTextField = "TeacherName";
                DropDownList1.DataValueField = "TeacherID";
                DropDownList1.DataBind();


                //add "select" at first location to do this insert method is used

                ListItem li = new ListItem("Select", "-1");
                DropDownList1.Items.Insert(0, li);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            if (DropDownList1.SelectedIndex == 0)
            {
                Response.Write("Please select a teacher<br/>");
            }
            else
            {
                Response.Write("<b>Your Teacher is  </b>"+ DropDownList1.SelectedItem.Text + "<br/>");
                Response.Write("<b>Your Teacher ID is  </b>" + DropDownList1.SelectedItem.Value + "<br/>");
                Response.Write("<b>Your Teacher Index is  </b>" + DropDownList1.SelectedIndex + "<br/>");
            }

            if (CheckBoxList1.SelectedItem == null)
            {
                Response.Write("Please select Favourite Book");
            }
            else
            {
                foreach (ListItem li in CheckBoxList1.Items)
                {
                    if (li.Selected)
                    {
                        Response.Write(li.Text + ",");
                        Response.Write(li.Value + ",");
                        Response.Write(CheckBoxList1.Items.IndexOf(li));
                        Response.Write("<br/>");
                    }
                }
            }
            
        }
    }
}