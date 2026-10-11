using GestorClientesApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<GestorClientesApi.AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Default")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<GerenciadorClientes>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/clientes", (GerenciadorClientes g) => g.Listar());

app.MapGet("/clientes/{id}", (int id, GerenciadorClientes g) =>
    g.Buscar(id) is Cliente c ? Results.Ok(c) : Results.NotFound());

app.MapPost("/clientes", (NovoClienteDto dto, GerenciadorClientes g) =>
{
    try
    {
        var c = g.Adicionar(dto.Nome, dto.Email, dto.Cpf);
        return Results.Created($"/clientes/{c.Id}", c);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { erro = ex.Message });
    }
});

app.MapDelete("/clientes/{id}", (int id, GerenciadorClientes g) =>
    g.Remover(id) ? Results.NoContent() : Results.NotFound());

app.Run();


