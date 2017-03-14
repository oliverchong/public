using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    public  const string str = "AA";
    protected void Page_Load(object sender, EventArgs e)
    {
       if(!Page.IsPostBack)
       {
           int i = 10;
           int j = 20;
           i = i + j;
           j = i - j;
           i = i - j;

          
           Response.Write(i);
           Response.Write(j);
           bool b = false;

           if (b = true)
           {
               Response.Write("yes");
           }

           else
           {
               Response.Write("no");
           }
           //  
         
           //  Response.Redirect("http://www.baidu.com");
       }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Server.Execute("Default2.aspx?message=Execute");
        Response.Write("Execute1");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("Default2.aspx?message=Transfer");
        Response.Write("Transfer1");
    }
}