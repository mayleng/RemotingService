<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RemotingTest.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            通过.Net的Remoting实现远程调用！
            Remoting的客户端
         
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="tcpClient" OnClick="Button1_Click" />&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="HTTPClient" OnClick="Button2_Click" />&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="IpCClient" OnClick="Button3_Click" />&nbsp;&nbsp;
    </form>
</body>
</html>
