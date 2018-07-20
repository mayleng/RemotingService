<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RemotingServer.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Remoting的server端！
         
            访问相应的channel客户端是，服务端必须要打开。
            <br />
            <br />
            <span style="color: rgb(0, 0, 0); font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">.NET Framework 4 提供了 3 种信道类型，它们分别通过 TCP、HTTP 和IPC 进行通信。此外，还可以创建自定义信道，这些信道使用其他协议通信。</span><br />
            <br />
            <br />
            <br />
           
        </div>
         <asp:Button ID="Button1" runat="server" Text="Tcp信道" OnClick="Button1_Click" />&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Http" OnClick="Button2_Click" />&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="IPC" OnClick="Button3_Click" />&nbsp;&nbsp;
    </form>
</body>
</html>
