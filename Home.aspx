<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MovieTicketBooking.User.Home" %>
<form runat="server">
    <h2>Available Movies</h2>
    <asp:DropDownList ID="ddlMovies" runat="server" />
    <br /><br />
    <asp:Button Text="Book Ticket" runat="server" OnClick="Book_Click" />
</form>
