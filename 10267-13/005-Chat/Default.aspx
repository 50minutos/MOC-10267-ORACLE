<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_005_Chat.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="header">
        </div>
        <div id="message">
            <p>
                Mensagem:<br />
                <asp:TextBox runat="server" ID="Mensagem" Width="400"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1Click" /></p>
        </div>
        <div id="grid">
            <asp:GridView ID="Mensagens" runat="server">
            </asp:GridView>
        </div>
        <div id="footer">
            by 50minutos &copy; 2012
        </div>
    </div>
    </form>
</body>
</html>
