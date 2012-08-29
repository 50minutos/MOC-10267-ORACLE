<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_002_ViewState.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            ViewState - WebForm1</h1>
        <p>
            Digite o seu nome:<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Digite a sua senha:<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" OnClick="Button1Click" runat="server" Text="Gravar ViewState" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" OnClick="Button2Click" runat="server" Text="Ler ViewState" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" OnClick="Button3Click" runat="server" Text="Context" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" OnClick="Button4Click" runat="server" Text="Session" />
        </p>
    </div>
    </form>
</body>
</html>
