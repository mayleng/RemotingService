using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using RemoteSample;
using System.Threading;

namespace RemotingTest
{
    public partial class IPcClient : System.Web.UI.Page
    {
        //对于IPC信道来说，使用一个管道名来区分而不是端口号

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

            ChannelServices.RegisterChannel(new IpcClientChannel(), false);
            RemoteObject remoteobj = (RemoteObject)Activator.GetObject(typeof(RemoteObject),
                "ipc://TestChannel/RemoteObject.rem");
            Response.Write("3+7=" + remoteobj.Sum(3, 7).ToString());
            Response.Write("<br/>");
            Response.Write("ipc+channel=" + remoteobj.StrAdd("ipc", "channel"));


            /*
            // 创建一个IPC信道。
            IpcChannel channel = new IpcChannel();
            // 注册这个信道。
           ChannelServices.RegisterChannel(channel,false);

            // 注册一个远程对象的客户端代理.
            WellKnownClientTypeEntry remoteType = new WellKnownClientTypeEntry(typeof(RemoteObject),
                "ipc://TestChannel/RemoteObject");
        RemotingConfiguration.RegisterWellKnownClientType(remoteType);
         RemoteObject service = new RemoteObject();
       
             Response.Write("The remote object has been called times: "+
             service.Sum(3,9));
            Response.Write("<br/>");
       */



        }
    }
}