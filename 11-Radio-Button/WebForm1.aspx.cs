using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _11_Radio_Button
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (MaleRadioButton.Checked)
            {
                Response.Write("Your Gender is " + MaleRadioButton.Text + "<br/>");
            }

            else if (FemaleRadioButton.Checked)
            {
                Response.Write("Your Gender is " + FemaleRadioButton.Text + "<br/>");
            }

            else if (UnknownRadioButton.Checked)
            {
                Response.Write("Your Gender is " + UnknownRadioButton.Text + "<br/>");
            }
        }
    }
}