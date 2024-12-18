# Cafe Shop Management System

Welcome to the **Cafe Shop Management System** repository! This project is a desktop application developed using **Core C#**, **Windows Forms**, and **MS SQL Server**. It is designed to manage various aspects of a cafe shop, including order management, menu handling, and sales tracking.

## Features

- **User-Friendly Interface**: Built with Windows Forms for ease of use.
- **Order Management**: Add, update, and delete customer orders.
- **Menu Management**: Manage cafe menu items with details like price and category.
- **Sales Tracking**: Generate daily, weekly, or monthly sales reports.
- **Secure Data Storage**: Data stored in an MS SQL Server database.
- **Login System**: Basic authentication for secure access.

## Prerequisites

To run this project, you need:

1. **.NET Framework 4.7.2 or later**
2. **MS SQL Server 2019 or later**
3. **Visual Studio 2019 or later**

## Installation

### Step 1: Clone the Repository

```bash
https://github.com/your-username/cafe-shop-management-system.git
```

### Step 2: Set Up the Database

1. Open MS SQL Server Management Studio.
2. Create a new database named `CafeShopDB`.
3. Run the SQL scripts located in the `DatabaseScripts` folder to set up the tables and seed data.

### Step 3: Configure the Connection String

1. Open the project in Visual Studio.
2. Navigate to the `App.config` file.
3. Update the connection string with your MS SQL Server credentials:

```xml
<connectionStrings>
    <add name="CafeShopDB" connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=CafeShopDB;Integrated Security=True;" providerName="System.Data.SqlClient" />
</connectionStrings>
```

### Step 4: Build and Run the Project

1. Build the solution in Visual Studio.
2. Run the application and start managing your cafe!

## Contributing

Contributions are welcome! To contribute:

1. Fork the repository.
2. Create a feature branch: `git checkout -b feature-name`.
3. Commit your changes: `git commit -m 'Add some feature'`.
4. Push to the branch: `git push origin feature-name`.
5. Open a pull request.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

## Contact

For any questions or feedback, feel free to contact:

- **Name**: Bilal Pasha
- **Email**: billopasho56@gmail.com
- **GitHub**: [Bilal-pasha](https://github.com/your-username)

Thank you for checking out the Cafe Shop Management System! Happy coding! ☕

