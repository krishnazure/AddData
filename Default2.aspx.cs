using Cassandra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
        ISession session = cluster.Connect("demo");
        session.Execute("insert into firstname(firstname) values ('" + TextBox1.Text + "')");

    }
}