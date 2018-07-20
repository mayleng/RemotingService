using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace RemotingServer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //TCPchannel
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/TcpChannelTest.aspx");
        }

        //http channel
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HttpChannelTest.aspx");
        }

        //ipc channel
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/IpcChannelTest.aspx");
        }
    }
}