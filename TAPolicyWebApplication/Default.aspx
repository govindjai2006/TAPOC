<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" Async="true" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TAPolicyWebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">&nbsp;</div>

    <div class="row">
        <div class="col-md-4">
            <asp:Button ID="btnGetPolicy" runat="server" Text="Get Policy From API" Height="41px" OnClick="btnGetPolicy_Click" Width="147px" />
        </div>

    </div>
    <div class="row">
        <div class="col-md-4">
            <asp:GridView ID="gvPlans" runat="server" AutoGenerateColumns="true"
                AllowPaging="true">
            </asp:GridView>
        </div>
    </div>

</asp:Content>
