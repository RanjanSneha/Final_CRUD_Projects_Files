using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Operation.Codes.Code_Files
{
    public partial class Cascading_DropdowList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = GetData("spgetContinents", null);
                DropDownList1.DataTextField = "ContinentName";
                DropDownList1.DataValueField = "ContinentID";
                DropDownList1.DataBind();

                ListItem liContinent = new ListItem("Select Continent", "100");
                DropDownList1.Items.Insert(0, liContinent);

                ListItem liCountry = new ListItem("Select Country", "200");
                DropDownList2.Items.Insert(0, liCountry);

                ListItem liCity = new ListItem("Select City", "300");
                DropDownList3.Items.Insert(0, liCity);

                DropDownList2.Enabled = false;
                DropDownList3.Enabled = false;
            }
        }
        private DataSet GetData(String SpName, SqlParameter SPParameter)
        {
            String CS = ConfigurationManager.ConnectionStrings["CascadingDropdownList"].ConnectionString;
            SqlConnection con=new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter(SpName, con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if(SPParameter != null)
            {
                da.SelectCommand.Parameters.Add(SPParameter);
            }
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedIndex == 0)
            {
                DropDownList2.SelectedValue = "200";
                DropDownList2.Enabled=false;

                DropDownList3.SelectedValue = "300";
                DropDownList3.Enabled = false;
            }
            else
            {
                DropDownList2.Enabled = true;
                SqlParameter parameter = new SqlParameter("@ContinentID", DropDownList1.SelectedValue);
               DataSet DS = GetData("spgetCountryByContinentID", parameter);

                DropDownList2.DataSource= DS;
                DropDownList2.DataTextField = "CountryName";
                DropDownList2.DataValueField = "CountryID";
                DropDownList2.DataBind();

                ListItem liCountry = new ListItem("Select Country", "200");
                DropDownList2.Items.Insert(0, liCountry);

                DropDownList3.SelectedIndex = 0;
                DropDownList3.Enabled = false;


            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList2.SelectedIndex == 0)
            {
                DropDownList3.SelectedValue = "300";
                DropDownList3.Enabled=false;
            }
            else
            {
                DropDownList3.Enabled = true;
                SqlParameter parameter = new SqlParameter("@CountryID", DropDownList2.SelectedValue);
               DataSet DS= GetData("spgetCitiesByCountryID", parameter);
                DropDownList3.DataSource= DS;
                DropDownList3.DataTextField = "CityName";
                DropDownList3.DataValueField = "CityID";
                DropDownList3.DataBind();

                ListItem liCity = new ListItem("Select City", "300");
                DropDownList3.Items.Insert(0, liCity);
            }
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    ListBox1.Items.Add(li.Text);
                }
            }

            if(CheckBoxList1.SelectedIndex == -1)
            {
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                Label1.ForeColor= System.Drawing.Color.Black;
            }
            Label1.Text=ListBox1.Items.Count.ToString() + " Item(s) selected";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
               String FileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (FileExtension.ToLower() != ".jpg" && FileExtension.ToLower() != ".png")
                {
                    Label2.Text = "Please upload a File in .jpg and .png Extension";
                    Label2.ForeColor = System.Drawing.Color.Red;
                }

                else
                {
                    int filesize = FileUpload1.PostedFile.ContentLength;
                    if (filesize > 2097152)
                    {
                        Label2.Text = "Maximum File Size (2MB) Exceeded";
                        Label2.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                        Label2.Text = "File Uploaded";
                        Label2.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            else {
                Label2.Text = "Please upload a File";
                Label2.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}