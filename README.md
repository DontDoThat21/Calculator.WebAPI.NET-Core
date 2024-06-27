# .NET Core Calculator Web API with Angular 
This project is a simple calculator API built using modern C# and .NET.

This product includes a RESTful API for a calculator application, providing basic arithmetic operations such as addition, subtraction, multiplication, and division.

# Features
Supports basic arithmetic operations.
Handles validation for input numbers.
Error handling for division by zero.
RESTful API design.

For the Angular 18 front-end project utilizing this API, see:
[https://github.com/DontDoThat21/Angular18Calculator]([url](https://github.com/DontDoThat21/Angular18Calculator))

# Technologies Used
C#
ASP.NET Core
Swagger
XUnit for unit tests
LINQ

# Getting Started
Prerequisites:
.NET SDK
Your favorite IDE

To use the API, send HTTP requests to the specified endpoints. Detailed documentation can be found in the API Endpoints section of the Swagger API (opens by default).

# API Endpoints
POST /api/calculator/add: Adds two numbers.
POST /api/calculator/subtract: Subtracts two numbers.
POST /api/calculator/multiply: Multiplies two numbers.
POST /api/calculator/divide: Divides two numbers.

# Example request (JSON):

json
Copy code
{
  "firstNumber": 10,
  "secondNumber": 5
}
Example response (JSON):

json
Copy code
{
  "result": 15
}

Thanks, and enjoy!
