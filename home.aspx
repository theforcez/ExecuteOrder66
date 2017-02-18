<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="gotoreg" runat="server" Text="Registration" OnClick="gotoreg_Click" />
         <asp:Button ID="gotologin" runat="server" Text="LogIn" OnClick="gotologin_Click" />
    </div>
    </form>
</body>
</html>
