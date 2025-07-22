**🎬 Movie Ticket Booking System**

📌 Project Overview
----------------------------------------
This Movie Ticket Booking System is a full-stack web application built using ASP.NET Web Forms (C#) for the frontend and backend, integrated with real AWS Services like Amazon S3, DynamoDB, CloudWatch, and SES. The system allows users to register, login, browse movies, book tickets, and receive booking confirmations via email. Admins can manage movie listings dynamically.

🚀 Project Objective
----------------------------------------
The aim of this project is to showcase cloud-based architecture using AWS services in a real-world web application, demonstrating your skills in:
* Building cloud-native web apps.
* Integrating AWS SDKs
* Using real-time storage and messaging solutions
* Designing scalable solutions without traditional databases
  
🧰 Technologies Used
----------------------------------------
🔷 Frontend:
* ASP.NET Web Forms (C#) – for web page logic and backend integration
* HTML5 – page structure and markup
* CSS3 – styling components
* Bootstrap 5 – responsive UI design
* JavaScript – for client-side interactions
  
🟧 Backend:
* ASP.NET Web Forms (C#) – server-side logic and form submission
* AWS SDK for .NET – to interact with AWS services securely
☁️ AWS Services:
* Amazon DynamoDB – for storing movies and bookings
* Amazon S3 – for storing and retrieving movie posters
* Amazon SES – for sending email confirmations to users
* Amazon CloudWatch Logs – for centralized logging of application events (admin viewable).
  
🛠️ Tools:
* Visual Studio 2022 – primary IDE
* AWS Management Console – for setting up services

👥 System Roles and Responsibilities
----------------------------------------
This application is designed with two key roles — each interacting with different parts of the system and AWS services.

**🧑‍💼 1. **Admin Role****

The Admin is responsible for:
* Logging into the admin dashboard
* Adding, editing, and deleting movies
* Uploading movie posters
* Setting available show timings
  
✅ AWS Services Admin Uses:
AWS Service Purpose Amazon S3 Upload movie posters Amazon DynamoDB Store and manage movie metadata (title, description, showtimes, image path)

**🎟️ 2. User Role**

The User can:
* Register and login
* Browse available movies
* Book tickets
* Select seats, date, time
* Receive ticket confirmation email with movie and seat details

✅ AWS Services User Uses:
AWS Service Purpose Amazon DynamoDB Store booking information Amazon SES Send booking confirmation email with ticket details Amazon S3 Load/display movie posters on homepage

🔄 Project Flow
----------------------------------------
**🛠️ Step 1: AWS IAM Setup – User Roles & SDK Permissions**

🎯 Objective : 
To securely connect our ASP.NET Web Forms application with AWS services (DynamoDB, S3, SES), we need to create an IAM User with programmatic access and assign the necessary permissions using AWS IAM. These credentials will be directly used in the C# code.

🪜 Steps to Set Up IAM for This Project

🔹 Step 1.1: Open IAM Console
* Go to : https://console.aws.amazon.com/iam/
* Click on Users, then Add users

🔹 Step 1.2: Create a New IAM User
* User name: MovieBookingUser
* Access type: ✅ Programmatic access

🔹 Step 1.3: Attach Required Policies
* Choose “Attach existing policies directly”
* Select the following AWS-managed policies:
* AmazonDynamoDBFullAccess
* AmazonS3FullAccess
* AmazonSESFullAccess

🔹 Step 1.4: Retrieve Credentials

After creating the user, download the Access key CSV file or copy: 1. Access Key ID  2. Secret Access Key
You’ll use these in your ASP.NET code to authenticate with AWS SDK.
use them directly in the code via the AWSSDK for .NET
var credentials = new BasicAWSCredentials("YOUR_ ACCESS_KEY", "YOUR_SECRET_KEY");

**🪣 Step 2: Amazon S3 Bucket Setup – Storing Movie Posters**

🎯 Objective :
To store and retrieve movie posters dynamically on both Admin and User pages, we use Amazon S3, a highly scalable object storage service. In this step, we will create an S3 bucket and configure it for secure access via AWS SDK in our ASP.NET Web Forms application.

🪜 Steps to Set Up Amazon S3 for This Project

🔹 Step 2.1: Open S3 Console
* Go to: https://s3.console.aws.amazon.com/s3

🔹 Step 2.2: Configure Bucket Settings
* Bucket name: movie-ticket-posters (Ensure the name is unique globally)
* Region: Asia Pacific (Mumbai) (ap-south-1)
* Uncheck Block all public access (only if you want public images). For this project, we keep images private and access them using pre-signed URLs.
* Leave all other settings as default.
* Click “Create bucket”

**🧮 Step 3: Amazon DynamoDB Setup – Storing Movies & Bookings**

🎯 Objective:

We use Amazon DynamoDB, a fast and flexible NoSQL database service, to dynamically store and retrieve:
🎬 Movie metadata (title, description, poster, show timings)
🎟️ User bookings (name, email, selected movie, date/time, seats)
This enables real-time dynamic updates without a traditional relational DB.

🪜 Steps to Set Up Amazon DynamoDB Tables

🔸 Step 3.1: Create Movies Table
* Go to: DynamoDB Console
* Enter the following:

| **Setting**   |    **Value**     |
| ------------- | ---------------  |
| Table Name    | Movies           |
| Partition Key | MovieId (String) |
| Sort Key      | (leave blank)    |
| Capacity Mode | On-demand        |
  

* Click Create Table.
  
🔸 Step 3.2: Create Bookings Table

| **Setting**   |    **Value**       |
| ------------- | ---------------    |
| Table Name    | Bookings           |
| Partition Key | BookingId (String) |
| Sort Key      | (leave blank)      |
| Capacity Mode | On-demand          |

Click Create Table

✉️ Step 4: Amazon SES (Simple Email Service) Setup – Email Confirmation Integration.

🎯 Objective:

We use Amazon SES to send Booking confirmation emails to users after successful ticket booking.

🔹 Step 4.1: Open Amazon SES Console
* URL: https://console.aws.amazon.com/ses
* Choose Region: Use the same region where you created other services

🔹 Step 4.3: IAM Permissions for SES
Ensure your IAM user has the following policy:

{

"Effect": "Allow",

"Action": [

"ses:SendEmail",

"ses:SendRawEmail"
],

"Resource": "*"

}

This allows your ASP.NET app to send email via SES SDK.

**🧩 Step 5: Page-by-Page AWS Integration Flow**

This step explains exactly where and how AWS services (S3, DynamoDB, SES) are used in different pages — both for Admin and User flows.

**🔹 Step 5.1: Login Page – Browse Movies (User Role)**

🧩 Purpose:

* Allow users and admins to login or register.
* No direct AWS SDK usage here.

🔧 Backend Logic:

* Hardcoded or simulated user-role-based login in C#.

  **🔹 Step 5.2: Home Page – Browse Movies (User Role)**

  Allow users to dynamically browse all currently available movies, including admin-uploaded movie posters and metadata from the Amazon S3 and DynamoDB services.

  ✅ AWS Service:

  * DynamoDB : The SDK sends a ScanRequest to fetch all movie entries.
  * S3 : Each movie has an image URL pointing to S3

  🧩 Purpose:

  * Dynamically fetch and display the list of movies uploaded by the admin.
  * Show movie posters stored in Amazon S3
 
 **🔹 Step 5.3: Booking Page – Browse Movies (User Role)**

 To allow users to book movie tickets by Selecting seats,Choosing a date and time,Saving booking to DynamoDB,Sending confirmation email via SES,Generating and uploading ticket PDF to     S3,Redirecting to the Ticket.aspx page with booking details

 ✅ AWS Service:

 * DynamoDB - Save Booking to DynamoDB
 * AWS SES - Send Email via SES (if checked)
 * S3 - Upload Ticket to S3

**🔹 Step 5.4: Ticket Page**

This page handles Generating a PDF ticket file. Uploading the PDF to Amazon S3. Providing download option to the user

 ✅ AWS Service:

 * AWS S3 - Upload and host the generated ticket PDF files.

**🔹 Step 5.5: Home Page (Admin Role)**

This page is the Admin Dashboard, which displays all movies currently listed in the system. These movie records are dynamically loaded from DynamoDB

**🔹 Step 5.6: ManageMovies Page**

This is the Admin movie management page, where the admin can Add a new movie (title, description, showtimes, and poster) , Edit an existing movie, Delete a movie

**🔹 Step 5.7: Logs.aspx — Admin Log Monitoring Page**

The Logs.aspx page provides an admin-friendly interface View recent system activity logs , Monitor operations like booking, PDF ticket generation, and email delivery , Simulate or extend real-time logging using Amazon CloudWatch Logs.



