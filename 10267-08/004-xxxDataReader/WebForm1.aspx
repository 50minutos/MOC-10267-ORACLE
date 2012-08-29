<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_004_xxxDataReader.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            <!--início - solução de "remover o botão, mantendo a funcionalidade da página"-->
            <%--<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>--%>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true"></asp:DropDownList>
            <!--fim-->
        </p>
        <p>
            <!--início - solução de "remover o botão, mantendo a funcionalidade da página"//-->
            <%--asp:Button ID="Button1" runat="server" Text="Clique aqui" />--%>
            <!--fim-->
        </p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>
