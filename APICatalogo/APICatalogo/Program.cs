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
 * EFCore: Entity Framework Core é um ORM (Object-Relational Mapper) que facilita a interação com bancos de dados relacionais em aplicações .NET
 *      Abordagem Code-First: Define as classes de domínio e o EF Core gera o banco de dados com base nessas classes com o recurso Migrations
 *      Recursos: 
 *      dotnet add package Pomelo.EntityFrameworkCore.MySql
 *      dotnet add package Microsoft.EntityFrameworkCore.Design
 *      dotnet tool install --global dotnet-ef
 *      dotnet tool update --global dotnet-ef
 *      dotnet ef
 *      
 * EF Core Migrations: Permite criar e aplicar alterações no esquema do banco de dados de forma incremental, mantendo o controle de versão do banco de dados
 * sincronizando o modelo de dados com as definições do EF Core. Alterações nas classes de domínio devem ser migradas para o banco de dados com o Migrations.
 *      dotnet ef migrations add NomeDaMigracao -> Cria o script de migração
 *      dotnet ef migrations list -> Lista as migrações existentes
 *      dotnet ef migrations remove NomeDaMigracao -> Remove a migração especificada
 *      dotnet ef database update -> Aplica as migrações pendentes ao banco de dados
 */