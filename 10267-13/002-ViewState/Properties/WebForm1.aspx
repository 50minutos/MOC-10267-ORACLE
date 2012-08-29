<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_002_ViewState.Properties.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <p>
                    Digite o nome:
                    <asp:TextBox ID="TextBox1" runat="server" Height="22px"></asp:TextBox>
                </p>
                <p>
                    Digite a senha:
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </p>
                <p>
                    Confirme a senha:
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                </p>
                <p>
                    <asp:Button ID="Button1" runat="server" onclick="Button1Click" Text="Enviar" />
                </p>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <p>
                    Nome:
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                </p>
                <p>
                    Senha:
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                </p>
                <p>
                    <asp:Button ID="Button2" runat="server" onclick="Button2Click" Text="Voltar" />
                </p>
            </asp:View>
        </asp:MultiView>
    </div>
    </form>
</body>
</html>
