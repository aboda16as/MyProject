using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace page1
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //page1 : textbox2  الى textbox1 يتم النقل من//
            //وقمت بلعمل على اذا ضغط المسخدم على الزر مرةاخر فتبقى القيمة ولاتتغير//
            if (TextBox1.Text != "0" && TextBox1.Text != "")
            {
                TextBox2.Text = TextBox1.Text;
                TextBox1.Text = "";
            }
            else if (TextBox2.Text != "0")
            {
                TextBox2.Text = TextBox2.Text;
                TextBox1.Text = "";
            }
        }
    }
}