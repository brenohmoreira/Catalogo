using APICatalogo.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

/**
 * SWAGGER: Conjunto de ferramentas que ajudam a documentar APIs RESTful
 * 
 * EFCore: Entity Framework Core � um ORM (Object-Relational Mapper) que facilita a intera��o com bancos de dados relacionais em aplica��es .NET
 *      Abordagem Code-First: Define as classes de dom�nio e o EF Core gera o banco de dados com base nessas classes com o recurso Migrations
 *      Recursos: 
 *      dotnet add package Pomelo.EntityFrameworkCore.MySql
 *      dotnet add package Microsoft.EntityFrameworkCore.Design
 *      dotnet tool install --global dotnet-ef
 *      dotnet tool update --global dotnet-ef
 *      dotnet ef
 *      
 * EF Core Migrations: Permite criar e aplicar altera��es no esquema do banco de dados de forma incremental, mantendo o controle de vers�o do banco de dados
 * sincronizando o modelo de dados com as defini��es do EF Core. Altera��es nas classes de dom�nio devem ser migradas para o banco de dados com o Migrations.
 *      dotnet ef migrations add NomeDaMigracao -> Cria o script de migra��o
 *      dotnet ef migrations list -> Lista as migra��es existentes
 *      dotnet ef migrations remove NomeDaMigracao -> Remove a migra��o especificada
 *      dotnet ef database update -> Aplica as migra��es pendentes ao banco de dados
 */