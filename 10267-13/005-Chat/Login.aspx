<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_005_Chat.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="header">
    </div>
    <div id="message">
        <p>
            Nome:<br />
            <asp:TextBox runat="server" ID="Nome" Width="100"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Entrar" OnClick="Button1Click" /></p>
    </div>
    <div id="footer">
        by 50minutos &copy; 2012
    </div>
    </form>
</body>
</html>
