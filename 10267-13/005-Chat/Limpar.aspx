<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Limpar.aspx.cs" Inherits="_005_Chat.Limpar" %>

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
        <h1>
            Vai apagar a coleção Application!!!</h1>
        <p>
            Senha:<br />
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password" Width="138px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1Click" Text="Limpar" />
        </p>
    </div>
    <div id="footer">
        by 50minutos &copy; 2012
    </div>
    </form>
</body>
</html>
