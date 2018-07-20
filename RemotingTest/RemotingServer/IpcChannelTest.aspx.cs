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
using System.Collections;

namespace RemotingServer
{
    public partial class IpcChannelTest : System.Web.UI.Page
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

            IDictionary dicProp = new Hashtable();
            dicProp["priority"] = "25";
            dicProp["portName"] = "TestChannel";
            dicProp["authorizedGroup"] = "Everyone"; //如果以服务方式运行，这句是必须的，否则客户端没有连接权限
      
            //注册通道
            IpcServerChannel channel = new IpcServerChannel(dicProp,null);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteObject),
               "RemoteObject.rem", WellKnownObjectMode.Singleton);

              // 打印这个信道的名称.
            Response.Write("这个信道名称为："+ channel.ChannelName);
            Response.Write("<br/>");
            Response.Write("这个信道的优先级为："+channel.ChannelPriority);
            Response.Write("<br/>");
            ChannelDataStore channelData = (ChannelDataStore)channel.ChannelData;
            string ss = "";
            foreach (string uri in channelData.ChannelUris)
            {
                ss += uri+";";
            }
            Response.Write(ss);
          

            /*
            // 创建一个IPC信道
            IpcChannel serverChannel = new IpcChannel("TestChannel");

            // 注册这个IPC信道.
            ChannelServices.RegisterChannel(serverChannel,false);
            
            // 注册知名对象
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteObject),
                "RemoteObject", WellKnownObjectMode.SingleCall);
            */


        }
    }
}