using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState_and_Events
{
    public partial class _Default : Page
    {

        int clickcount = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                TextBox1.Text = "0";

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (ViewState["Clicks"] != null)
            {
                clickcount = (int)ViewState["Clicks"] + 1;

            }

            TextBox1.Text = clickcount.ToString();
            ViewState["Clicks"] = clickcount;

        }

       
    }
}