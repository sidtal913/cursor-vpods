# Self-hosted .NET web application

Minimal full-stack hire project: ASP.NET Core backend + React PWA frontend.

## Backend (ASP.NET Core)

See [Backend/README.md](Backend/README.md) for build and run instructions.

Quick start:

```bash
docker compose up -d postgres
cd Backend && dotnet run
```

Endpoints:

- `GET /health` — health check (includes PostgreSQL connectivity)
- `GET /api/hello` — hello message from the database

## Frontend (React PWA)

The React frontend is maintained separately under the frontend hire lane. Once present, run it per that package's README (typically `npm install && npm run dev`).

## Database

Local PostgreSQL is provided via `docker-compose.yml` at the repository root.
