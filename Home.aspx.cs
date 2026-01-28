using System;
using MovieTicketBooking.App_Code;

namespace MovieTicketBooking.User
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlMovies.DataSource = DBHelper.GetMovies();
                ddlMovies.DataTextField = "Title";
                ddlMovies.DataBind();
            }
        }

        protected void Book_Click(object sender, EventArgs e)
        {
            Response.Redirect("Booking.aspx?movie=" + ddlMovies.SelectedValue);
        }
    }
}
