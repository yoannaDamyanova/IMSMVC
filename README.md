
## 📦 **Stockly** – Inventory Management, Made Simple

Welcome to **Stockly** – your sleek, efficient, and user-friendly **Inventory Management System** that does all the boring stuff so you don’t have to.

No more Excel chaos. No more wondering *“Where did all the USB mice go?”*  
Stockly is here to take charge of your stock like an over-caffeinated warehouse manager on a mission.

---

### 🚀 Features

#### 🔐 Authentication & Roles
- Secure login system with Identity
- Admin-only dashboard for high-level management
- Role-based access (e.g. admin, employee)

#### 📁 Product Management
- Add, edit, and delete product listings
- Track stock quantity, price, categories, and descriptions
- Visual overview of all products in a clean table layout

#### 🏷️ Category & Brand Control
- Manage product categories and brands with ease
- Filter products by category or brand for fast lookups

#### 📦 Inventory Tracking
- Monitor real-time stock levels
- Prevent negative stock with smart validation
- Automatic stock status updates (e.g. low stock warning)

#### 🧑‍💼 User Management (Admin-only)
- View all registered users
- Assign roles, manage accounts, and keep things tight

### 🛠️ Built With
- **ASP.NET Core MVC** with Razor Pages
- **Entity Framework Core** for database management
- **SQL Server** as the default DB
- **Bootstrap 5** for a clean and responsive UI

### 🧪 How to Run

1. Clone the repo:
```bash
git clone https://github.com/yourusername/Stockly.git
```

2. Open the solution in Visual Studio

2. Open the solution in Visual Studio

3. In `appsettings.json`, update the connection string to match your SQL Server name:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=StocklyDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

4. Run the project (`Ctrl + F5`)

> Default admin credentials are seeded. Look in the SeedData.cs.


### ✨ Why Stockly?

Stockly doesn’t try to be an enterprise ERP system from 2003. It’s lightweight, fast, and does one thing really well: **managing your stock without driving you insane**.

Whether you’re running a small online store or a full warehouse — Stockly’s got your back.
