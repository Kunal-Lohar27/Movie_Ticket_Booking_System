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
🛠️ Step 1: AWS IAM Setup – User Roles & SDK Permissions
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

