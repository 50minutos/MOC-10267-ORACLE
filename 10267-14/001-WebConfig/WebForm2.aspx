<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="_001_WebConfig.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Edição de chaves do web.config
        </h1>
        <p>
            Digite o nome da chave:
            <br/>
            <asp:TextBox ID="TextBox1" runat="server" Width="200"></asp:TextBox>
        </p>
        <p>
            Digite o conteúdo:
            <br/>
            <asp:TextBox ID="TextBox2" runat="server" Width="200"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text=":: clique aqui ::" OnClick="Button1Click" />
        </p>
    </div>
    </form>
</body>
</html>
