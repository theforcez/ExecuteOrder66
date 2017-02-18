<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="ActivationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label ID="Label_welcome" runat="server" Text="Welcome,"></asp:Label>

        <p>
            <asp:Button ID="b_logout" runat="server" Text="LogOut" OnClick="b_logout_Click" />
        </p>
        </div>
        <div>
        <p>
            Order:</p>
        <p>
            <asp:TextBox ID="order" runat="server" Height="25px" Width="377px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Send" runat="server" Text="Send" OnClick="Send_Click" Width="380px" />
        </p>
            </div>
    </form>
</body>
</html>
