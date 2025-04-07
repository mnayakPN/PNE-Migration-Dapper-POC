using Microsoft.Data.SqlClient;
using PNE_Migration_Dapper_POC.Controller;
using PNE_Migration_Dapper_POC.Repositories;
using PNE_Migration_Dapper_POC.Services;
using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped<IDbConnection>(_ =>
            new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")));
        
        // Register Repositories and Services
        builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
        builder.Services.AddScoped<ICustomerService, CustomerService>();

        // Register Swagger
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();
        // Enable Swagger UI
        app.UseSwagger();
        app.UseSwaggerUI();

        // Register API Routes
        app.RegisterCustomerEndpoints();

        app.Run();
    }
}