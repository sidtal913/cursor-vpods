using Backend.Data;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' is not configured.");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddHealthChecks()
    .AddDbContextCheck<AppDbContext>("postgresql");

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins(
                builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>()
                ?? ["http://localhost:5173", "http://localhost:3000"])
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

app.UseCors();

app.MapGet("/api/hello", async (AppDbContext db, CancellationToken cancellationToken) =>
{
    var greeting = await db.Greetings
        .AsNoTracking()
        .OrderBy(g => g.Id)
        .FirstOrDefaultAsync(cancellationToken);

    return Results.Ok(new
    {
        message = greeting?.Message ?? "Hello from ASP.NET Core",
        timestamp = DateTimeOffset.UtcNow
    });
})
.WithName("GetHello");

app.MapHealthChecks("/health");

app.Run();
