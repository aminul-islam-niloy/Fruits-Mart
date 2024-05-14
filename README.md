# Fruits Mart

Fruits Mart is a simple ASP.NET Core web API Project that provides information Form Managing Fruits Shop and providing CRUD operation.

## Getting Started

To get started with Project , follow these steps:

1. Clone the repository:

git clone:

```
 https://github.com/aminul-islam-niloy/Fruits-Mart.git
```

2. Open the solution in Visual Studio.

3. Build the solution.

4. Run the application.

5. Use the Swagger UI or send HTTP requests to `https://localhost:7246/api/Items` to get information for Fruits.

## Configuration

The application is configured to use the RESTful API

Connection on appseting.json

```
  "ConnectionStrings": {
    "DefaultConnection": "Server=AMINUL\\SQLEXPRESS; Database=FruitsMartDb;Trusted_Connection=True;"
  },
```

## Dependencies

The project uses the following dependencies:

```
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
```

To Add Service:

```
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
```

## Testing

For Testing, there are my Service like Postman or Swagger

use this for Default Swagger

```
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
```

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please feel free to open an issue or create a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

Feel free to customize this README file further to include additional information about your project, such as how to extend the functionality, testing procedures, or any other relevant details.
