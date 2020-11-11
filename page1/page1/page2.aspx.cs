using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace page1
{
    public partial class page21 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Button1.Enabled)
            {
                CheckBox.Checked = Button1.Enabled;
            }
        }
        protected void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}