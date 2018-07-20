using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using RemoteSample;
using System.Threading;

namespace RemotingTest
{
    public partial class HttpClient : System.Web.UI.Page
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

            ChannelServices.RegisterChannel(new HttpClientChannel(), false);
            RemoteObject remoteobj = (RemoteObject)Activator.GetObject(typeof(RemoteObject),
                "http://192.168.0.178:7777/RemoteObject");
            Response.Write("2+6=" + remoteobj.Sum(2, 6).ToString());
            Response.Write("<br/>");
            Response.Write("http+channel=" + remoteobj.StrAdd("http", "channel"));




        }
    }
}