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

namespace RemotingServer
{
    public partial class TcpChannelTest : System.Web.UI.Page
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

            //注册通道
            TcpServerChannel channel = new TcpServerChannel(6666);
            ChannelServices.RegisterChannel(channel,false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteObject),
               "RemoteObject", WellKnownObjectMode.SingleCall);

        }
    }
}