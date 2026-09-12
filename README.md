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

See [Frontend/README.md](Frontend/README.md) for build and run instructions.

Quick start:

```bash
cd Frontend
npm install
npm run dev
```

Open [http://localhost:5173](http://localhost:5173) for the hello page. Production build: `npm run build && npm run preview`.

## Database

Local PostgreSQL is provided via `docker-compose.yml` at the repository root.
