# 🏭 Jory Tissue Factory Management System

This is a graduation project that simulates an Enterprise Resource Planning (**ERP**) system for a tissue factory. It consists of three integrated parts:

1️⃣ **Desktop Application** for managing all factory operations.  
2️⃣ **ASP.NET 8 Web API** to connect the desktop app and the mobile app for report exchange.  
3️⃣ **Mobile App** for the factory manager to view daily reports.

---

## 📌 **Project Goal**

The system aims to digitize the management of the tissue factory by providing an integrated platform for administration, staff, and the manager to track all activities from production to sales and expenses.

---

## 🏗️ **System Components**

### 🖥️ **Desktop Application**

- **Technologies:**

  - C# (Windows Forms)
  - SQL Server
  - ADO.NET
  - 3-Tier Architecture

- **Features:**
  1. **Home Page:** Dashboard providing an overview of factory operations.
  2. **User Management:** Add and edit users and manage their permissions.
  3. **Customer Management:** Register customers and manage their data.
  4. **Sales Management:** Record sales operations and display invoices.
  5. **Purchases Management:** Register purchase orders and track suppliers.
  6. **Production Management:** Log and monitor daily production processes.
  7. **Expenses Management:** Track administrative and operational expenses.
  8. **Inventory Management:** Manage raw material and finished product quantities in stock.
  9. **Reports:** Generate periodic and comprehensive performance reports.
  10. **Electricity Management:** Monitor electricity consumption and bills.
  11. **Cashbox Management:** Update currency exchange rates and handle cash transactions.
  12. **Logout:** Securely end the current session.

---

### 🌐 **ASP.NET 8 Web API**

- **Purpose:** Provide an API layer to connect the database with the mobile application.
- **Technologies:**
  - ASP.NET 8
  - SQL Server
  - ADO.NET
  - 3-Tier Architecture

---

### 🚀 **Hosting**

- Hosted for free on **Monster ASP.NET Hosting**

---

### 📱 **Mobile Application**

- **Purpose:** Allow the factory manager to view daily reports remotely.
- **Technologies:**
  - Flutter
  - Dart

---

## 📂 **How It Works**

- All data is recorded and managed through the desktop application.
- Data is exchanged with the mobile app via the ASP.NET 8 API.
- The manager can check up-to-date reports and statistics through the mobile app anytime.

---

## ✅ **How to Run Locally**

### 📌 **Desktop Application**

1. Open the project in Visual Studio.
2. Ensure the database connection (SQL Server) is properly configured.
3. Run the application.

### 📌 **ASP.NET 8 API**

1. Open the project in Visual Studio.
2. Configure the database connection.
3. Run the API with:
   ```bash
   dotnet run
   ```

### 📌 **Mobile Application**

1. Open the project in Android Studio or VS Code.
2. Connect it to the API.
3. Run the app on an emulator or a real device.

---

## 📑 **More Information**

📌 **For more details about this project, please download the PDF file named:**  
**📄 Graduation Project - Tissue Factory Management System**

---

👤 **Created by:** Salem Ben Mofleh
📧 **Email:** [salem@gmail.com](salembenmofleh@gmail.com)
📢 **Feel free to share feedback and contributions!**
