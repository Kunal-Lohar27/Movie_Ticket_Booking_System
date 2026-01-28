using System;
using MovieTicketBooking.App_Code;

namespace MovieTicketBooking.Admin
{
    public partial class ManageMovies : System.Web.UI.Page
    {
        protected void AddMovie_Click(object sender, EventArgs e)
        {
            DBHelper.AddMovie(txtMovie.Text, DateTime.Parse(txtTime.Text));
            AWSHelper.LogToCloudWatch("Movie added by admin");
        }
    }
}
