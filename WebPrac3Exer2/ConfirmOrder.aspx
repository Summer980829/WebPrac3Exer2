<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmOrder.aspx.cs" Inherits="WebPrac3Exer2.ConfirmOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>FLYING BREAKFAST.COM</strong>
        <br />
        <p>Order your breakdast online. Online orders starts 2.00am - 11am everyday.</p>
            <asp:Label ID="lblTimeNow" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblOrder" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblReceiveTime" runat="server" Text=""></asp:Label>
        <br />
        </div>
    </form>
</body>
</html>
