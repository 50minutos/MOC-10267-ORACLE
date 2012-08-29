<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="_004_LoginUsandoSession.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>
            Login</h1>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <p>
                    Nome:<br />
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </p>
                <p>
                    Senha:<br />
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </p>
                <p>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1Click" Text="Logar" />
                </p>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <h1>
                    Você está logado.</h1>
            </asp:View>
        </asp:MultiView>
    </div>
</asp:Content>
