using System;
using System.Data;
using System.Data.SqlClient;

namespace MovieTicketBooking.App_Code
{
    public static class DBHelper
    {
        private static string conn =
            @"Data Source=.;Initial Catalog=MovieDB;Integrated Security=True";

        public static DataTable GetMovies()
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Movies", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void AddMovie(string title, DateTime showTime)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Movies (Title, ShowTime) VALUES (@t,@s)", con);
                cmd.Parameters.AddWithValue("@t", title);
                cmd.Parameters.AddWithValue("@s", showTime);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void AddBooking(string user, string movie, int seats)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Bookings VALUES (@u,@m,@s,GETDATE())", con);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@m", movie);
                cmd.Parameters.AddWithValue("@s", seats);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
