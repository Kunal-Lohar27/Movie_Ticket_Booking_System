using System;

namespace MovieTicketBooking.App_Code
{
    public static class AWSHelper
    {
        public static void UploadToS3(string fileName)
        {
            Console.WriteLine($"[S3] Uploaded file: {fileName}");
        }

        public static void SendEmail(string to, string subject)
        {
            Console.WriteLine($"[SES] Email sent to {to} | Subject: {subject}");
        }

        public static void LogToCloudWatch(string message)
        {
            Console.WriteLine($"[CloudWatch] {message}");
        }
    }
}
