<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle" class="text-center">INICIO SESIÓN</h1>
        </section>

        <div class="row justify-content-center">
            <div class="col-4">
                <asp:Panel ID="pnlLogin" runat="server" DefaultButton="btnSignIn">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:Panel ID="pnlLoginForm" runat="server">
                                <div class="form-group">
                                    <asp:Label ID="lblUsuario" runat="server" Text="Usuario" CssClass="form-label"></asp:Label>
                                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblPassword" runat="server" Text="Contraseña" CssClass="form-label"></asp:Label>
                                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group text-center">
                                    <br />
                                    <asp:Button ID="btnSignIn" runat="server" Text="Iniciar Sesión" CssClass="btn btn-primary" OnClick="btnSignIn_Click" />
                                </div>
                                <br />

                                <div class="col">
                                    <asp:Label ID="LabelMessage" runat="server" CssClass="text-opacity-75"></asp:Label>
                                </div>
                            </asp:Panel>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </asp:Panel>
            </div>
        </div>
    </main>

</asp:Content>
