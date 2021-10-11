using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FOR_loops
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] first = new [] { 1, 2, 3, 4, 5 };
            int[] second = new[] { 1, 2, 3, 4, 5 };
            
                for (int i = 0; i < first.Length; i++)
                {
                 for (int j = 0; j < second.Length; j++)
                 {
                    Label1.Text += String.Format("{0} + {1} = {2} <br />", first[i], second[j], first[i] + second[j]);
                 }
                }
           
        }
    }
}