<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IPcClient.aspx.cs" Inherits="RemotingTest.IPcClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ipc client
            <p>
            IPC 信道比 TCP 或 HTTP 信道要快得多。但是IPC只在本机应用之间通信.
            。所以，在客户端和服务端在同一台机器时，我们可以通过注册IPCChannel来提高Remoting的性能。但如果客户端和服务端不在同一台机器时，我们不能注册IPCChannel。
            </p>
                </div>
    </form>
</body>
</html>
