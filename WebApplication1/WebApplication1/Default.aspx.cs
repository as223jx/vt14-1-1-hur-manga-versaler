using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Model;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Result.Text = String.Format("Din text innehåller {0} versaler.", TextAnalyzer.GetNumberOfCapitals(TextBox.Text));
            Button.Visible = false;
            PlaceHolder1.Visible = true;
            TextBox.Enabled = false;
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            PlaceHolder1.Visible = false;
            TextBox.Text = "";
            Button.Visible = true;
            TextBox.Enabled = true;
        }
    }
}