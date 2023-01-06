using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using DapperExercise;
using System.Transactions;
//^^^^MUST HAVE USING DIRECTIVES^^^^

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
string connString = config.GetConnectionString("DefaultConnection");
IDbConnection conn = new MySqlConnection(connString);

#region Dapper Exercise One
var repo = new DapperDepartmentRepository(conn);
var departments = repo.GetAllDepartments();

foreach (var item in departments)
{
    Console.WriteLine($"Department: {item.Name}");
}

Console.WriteLine("Type a new Department name");
var newDepartment = Console.ReadLine();

repo.InsertDeparment(newDepartment);
IEnumerable<Department> updatedDepartments = repo.GetAllDepartments();

foreach (var item in updatedDepartments)
{
    Console.WriteLine($"Department: {item.Name}");
}
#endregion

#region Dapper Exercise Two
var productRepo = new DapperProductRepository(conn);
var products = productRepo.GetAllProducts();

foreach (var item in products)
{
    Console.WriteLine($"Product Name: {item.Name} ");
    Console.WriteLine($"Product Price: {item.Price} ");
    Console.WriteLine($"CategoryID - { item.CategoryID} ");
    Console.WriteLine();
}

#endregion