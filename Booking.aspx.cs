using System;
using MovieTicketBooking.App_Code;

namespace MovieTicketBooking.User
{
    public partial class Booking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string movie = Request.QueryString["movie"];
            DBHelper.AddBooking("DemoUser", movie, 2);
            AWSHelper.SendEmail("user@email.com", "Booking Confirmation");
            AWSHelper.LogToCloudWatch("Ticket booked");
        }
    }
}
