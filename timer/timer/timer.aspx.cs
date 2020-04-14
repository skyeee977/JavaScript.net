using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace timer
{
    public partial class timer : System.Web.UI.Page
    {
        static string a;
        protected void Page_Load(object sender, EventArgs e)
        {
            Button2.Attributes.Add("onclick","end()");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           Label1.Text= a;
        }
        [System.Web.Services.WebMethod()]
        public static string getJson(string time)
        {
            a = time;

            return time;
        }
    }
}