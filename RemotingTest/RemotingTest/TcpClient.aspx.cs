using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemoteSample;
using System.Threading;

namespace RemotingTest
{
    public partial class TcpClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(20);

            // 注销已有的通道（当无法注册时使用）
            if (ChannelServices.RegisteredChannels.GetLength(0) > 0)
            {
                foreach (IChannel channel1 in ChannelServices.RegisteredChannels)
                {
                    ChannelServices.UnregisterChannel(channel1);
                }
            }

            ChannelServices.RegisterChannel(new TcpClientChannel(),false);
            RemoteObject remoteobj = (RemoteObject)Activator.GetObject(typeof(RemoteObject),
                "tcp://192.168.0.178:6666/RemoteObject");
            Response.Write("1+5="+remoteobj.Sum(1,5).ToString());
            Response.Write("<br/>");
            Response.Write("tcp+channel=" + remoteobj.StrAdd("tcp", "channel"));

        }
    }
}