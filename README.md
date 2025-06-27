# 🍽️ Food Delivery App

A modular, scalable **Food Delivery** platform built with ASP.NET Core and C#. It follows a clean **Domain‑Repository‑Service‑Web** architecture to provide a solid foundation for adding features.

## 📁 Project Structure

```
EShop.Domain/        — Core models (e.g., Order, MenuItem, Customer)  
EShop.Repository/    — Data access layer (Entity Framework, repositories)  
EShop.Service/       — Business logic (order processing, pricing, etc.)  
EShop.Web/           — ASP.NET Core MVC web frontend and API controllers  
EShopApplication.sln — Solution file  
.gitignore
```

## 🛠️ Technologies

- .NET 8 with C#
- ASP.NET Core MVC + Web API
- Entity Framework Core for data persistence
- SQL Server (by default; easy to swap DB providers)
- HTML/CSS/JavaScript for UI interactions

## 🚀 Setup & Usage

1. **Clone the repo**
    ```bash
    git clone https://github.com/viktorijatodosieva/Food_Delivery_App.git
    cd Food_Delivery_App
    ```

2. **Configure the database**  
   Update the connection string in `EShop.Web/appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=.;Database=FoodDelivery;Trusted_Connection=True;"
   }
   ```

3. **Apply Migrations**  
   From project root run:
   ```bash
   cd EShop.Repository
   dotnet ef database update
   ```

4. **Run the Web App**  
   ```bash
   cd ../EShop.Web
   dotnet run
   ```
   By default, the app will run at `https://localhost:5001`.

## ✅ Features

- Customer workflow: browse menus, place orders
- Admin tools: manage dishes, orders, availability
- Clean separation of concerns for maintainability and testing


