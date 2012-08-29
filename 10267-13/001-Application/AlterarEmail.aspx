<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlterarEmail.aspx.cs" Inherits="_001_Application.AlterarEmail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            E-mail:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Clique aqui" 
                onclick="Button1Click" /></p>
    </div>
    </form>
</body>
</html>
