<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageMovies.aspx.cs" Inherits="MovieTicketBooking.Admin.ManageMovies" %>
<form runat="server">
    <h2>Manage Movies</h2>
    Movie Name:
    <asp:TextBox ID="txtMovie" runat="server" /><br /><br />
    Show Time:
    <asp:TextBox ID="txtTime" runat="server" /><br /><br />
    <asp:Button Text="Add Movie" runat="server" OnClick="AddMovie_Click" />
</form>
