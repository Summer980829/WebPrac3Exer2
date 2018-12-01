<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderFood.aspx.cs" Inherits="WebPrac3Exer2.OrderFood" %>

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
        <br />
    
    <table>
        <tr>
            <td>Breakfast Set</td>
            <td>
                <asp:RadioButtonList ID="rblSet" runat="server" OnSelectedIndexChanged="rblSet_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem>Set 1</asp:ListItem>
                    <asp:ListItem>Set 2</asp:ListItem>
                    <asp:ListItem>Set 3</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        
    </table>
        <asp:Label ID="lblSetDetail" runat="server" Text=""></asp:Label>
    
    <br />
    
    <br />    
    <table border="1" style="width:30%">
        <tr>
            <td></td>
            <td>Quantiy</td>
            <td>Total(RM)</td>
        </tr>

        <tr>
            <td>
                <asp:CheckBox ID="cbSet1" runat="server" Text="Set 1" AutoPostBack="True" />
            </td>
            <td>
                <asp:TextBox ID="txtSet1" runat="server" Width="25px" AutoPostBack="True"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblPriceSet1" runat="server" Text="" AutoPostBack="True"></asp:Label>
            </td>
        </tr>

        <tr>
            <td>
                <asp:CheckBox ID="cbSet2" runat="server" Text="Set 2" AutoPostBack="True" />
            </td>
            <td>
                <asp:TextBox ID="txtSet2" runat="server" Width="25px" AutoPostBack="True"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblPriceSet2" runat="server" Text="" AutoPostBack="True"></asp:Label>
            </td>
        </tr>

        <tr>
            <td>
                <asp:CheckBox ID="cbSet3" runat="server" Text="Set 3" AutoPostBack="True"/>
            </td>
            <td>
                <asp:TextBox ID="txtSet3" runat="server" Width="25px" AutoPostBack="True"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblPriceSet3" runat="server" Text="" AutoPostBack="True"></asp:Label>
            </td>
        </tr>

        <tr>
            <td></td>
            <td>Total(RM)</td>
            <td>
                <asp:Label ID="lblTotalPrice" runat="server" Text=""></asp:Label>
            </td>
        </tr>

    </table>
        <br />
        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" 
            OnMouseOver="this.value='Click if confirm to reset selection'" 
            OnMouseOut="this.value='Cancel'"/>
        <br /><br />
        <asp:Button ID="btnConfirm" runat="server" Text="Confirm Order" PostBackUrl="~/ConfirmOrder.aspx" 
            OnClientClick="javascript:alert('This page is to confirm your breakfast order')" OnClick="btnConfirm_Click" />
       
   </div>
    </form>
</body>
</html>
