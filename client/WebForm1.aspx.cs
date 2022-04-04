using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using client.ServiceReference1;
using System.Data;

namespace client
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        protected void Button1_Click(object sender, EventArgs e)
        {
            InsertUser u = new InsertUser();
            u.Name = TextBox1.Text;
            u.Price = TextBox2.Text;
            string r = client.Insert(u);
            Label4.Text = r.ToString();

        }

      

        protected void Button3_Click(object sender, EventArgs e)
        {
            UpdateUser u = new UpdateUser();
            u.UID =int.Parse( TextBox3.Text);
            u.Name = TextBox1.Text;
            u.Price = TextBox2.Text;
            string result = client.Update(u);
            Label4.Text = result.ToString();
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DeleteUser d = new DeleteUser();
            d.UID = int.Parse(TextBox3.Text);
            string res = client.Delete(d);
            Label4.Text = res.ToString();
        }
    }
} 