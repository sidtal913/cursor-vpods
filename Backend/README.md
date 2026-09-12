# Backend — ASP.NET Core API

Self-hosted ASP.NET Core 8 Web API with PostgreSQL via Entity Framework Core.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/) (for local PostgreSQL)

## Local development

### 1. Start PostgreSQL

From the repository root:

```bash
docker compose up -d postgres
```

This starts PostgreSQL on `localhost:5432` with:

| Setting  | Value               |
|----------|---------------------|
| Database | `vpods_hire`        |
| User     | `vpods`             |
| Password | `vpods_dev_password`|

### 2. Run the API

```bash
cd Backend
dotnet run
```

The API listens on `http://localhost:5159` by default (see `Properties/launchSettings.json`).

### 3. Verify endpoints

```bash
curl http://localhost:5159/health
curl http://localhost:5159/api/hello
```

## Configuration

Connection strings and CORS origins are in `appsettings.json` and `appsettings.Development.json`. Override with environment variables or user secrets for non-local deployments:

```bash
export ConnectionStrings__DefaultConnection="Host=...;Port=5432;Database=...;Username=...;Password=..."
```

## Build

```bash
dotnet build
```

## Project layout

| Path | Purpose |
|------|---------|
| `Program.cs` | Kestrel host, DI, endpoints |
| `Data/AppDbContext.cs` | EF Core DbContext |
| `Models/` | Domain models / DTOs |
| `Migrations/` | EF Core database migrations |
