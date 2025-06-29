# 📦 ASP.NET Core Web API Project

A simple Web API built with **ASP.NET Core** and **Entity Framework Core**, created to put my studies into practice.

---

## ✨ Features

- ASP.NET Core Web API
- Entity Framework Core (Code First)
- Database migrations
- Modular and clean project structure
- Ready for local development

---

## ⚙️ Getting Started

Follow these steps to set up and run the project locally:

### 1️⃣ Clone the repository
```
git clone https://github.com/brenohmoreira/Catalogo.git
cd Catalogo
```

### 2️⃣ Restore dependencies
```
dotnet restore
```

### 3️⃣ Configure the database
Make sure your connection string is correct in appsettings.json:
```
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=CatalogoDB;User Id=root;Password=;"
}
```

### 4️⃣ Apply migrations
If you don't have the EF Core tools installed:
```
dotnet tool install --global dotnet-ef
```
Create the database and apply the latest migration:
```
dotnet ef database update
```

### 5️⃣ Run the project
```
dotnet run
```
The API should start at:

https://localhost:5001 or http://localhost:5000 (default port)

---

## 🛠️ Useful Commands

### Add a new migration
```
dotnet ef migrations add MigrationName
```

### Update the database
```
dotnet ef database update
```

### Remove the last migration
```
dotnet ef migrations remove
```

---

## 📚 Motivation

### This project was created to:
- Practice what I've learned about ASP.NET Core and C#
- Apply EF Core concepts like migrations and data seeding
- Improve my understanding of RESTful API design

---

## ✅ Technologies Used

- .NET 8 (or latest)
- ASP.NET Core Web API
- Entity Framework Core
- MySQL

---

## 📝 License
This project is for study purposes.
Feel free to use it, fork it, and adapt it!

## 🙋‍♂️ Author
Breno Moreira
[GitHub](https://github.com/brenohmoreira) – [LinkedIn](https://www.linkedin.com/in/breno-am/)

