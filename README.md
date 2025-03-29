# Budget Wizard API

## Overview
Budget Wizard API is the backend service for the Budget Wizard mobile application. This API is built using C# and provides endpoints for managing users' financial data, including expenses, budgets, and reports. The frontend will be developed using Angular and Ionic for a seamless mobile experience.

## Features
- User authentication and authorization
- Expense tracking and categorization
- Budget planning and alerts
- Financial reports and insights
- Integration with third-party financial services

## Tech Stack
- **Backend:** C# (.NET Core Web API)
- **Frontend:** Angular & Ionic (Mobile App)
- **Database:** SQL Server
## Setup & Installation

### Prerequisites
- .NET SDK 6.0+
- SQL Server
- Node.js & npm

### Steps
1. **Clone the repository:**
   ```sh
   git clone https://github.com/hemantshirsath/BudgetWidzardAPI.git
   cd budget-wizard-api
   ```
2. **Set up environment variables:**
   - Create an `appsettings.json` file in the `BudgetWizard.API` project and configure the database connection string.
3. **Restore dependencies:**
   ```sh
   dotnet restore
   ```
4. **Run database migrations:**
   ```sh
   dotnet ef database update
   ```
5. **Start the API:**
   ```sh
   dotnet run
   ```



