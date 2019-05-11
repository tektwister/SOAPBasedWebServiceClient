using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyClientWebsite : System.Web.UI.Page
{
    // declare a reference to web service
    private ServiceReference.SOAPBasedWebServiceClient client;
    protected void Page_Load(object sender, EventArgs e)
    {
        client = new ServiceReference.SOAPBasedWebServiceClient();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = client.Welcome(TextBox1.Text);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int a=Int32.Parse(TextBox2.Text);
        int b=Int32.Parse(TextBox3.Text);
        TextBox4.Text = client.Add(a, b).ToString();;
    }
}