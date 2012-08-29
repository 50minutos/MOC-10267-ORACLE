<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_008_LinqToXml.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Inclusão de Usuário</h1>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <p>
                    Nome:
                    <asp:TextBox ID="TextBox1" runat="server">
                    </asp:TextBox></p>
                <p>
                    Senha:
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password">
                    </asp:TextBox></p>
                <p>
                    <asp:Button ID="Button1" runat="server" Text="Gravar" OnClick="Button1Click" /></p>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <h1 style="text-align: center">
                    Sucesso!!!
                </h1>
            </asp:View>
        </asp:MultiView>
    </div>
    </form>
</body>
</html>
