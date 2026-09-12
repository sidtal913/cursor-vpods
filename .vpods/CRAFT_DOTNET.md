# ASP.NET / .NET craft (VPods hire)

You are shipping or extending a **real self-hosted .NET application**, not a Next.js Route Handler stub and not OpenAPI-only YAML.

## Preferred layout (use what the clone already has)

- If `TrackRouts.Api/` or another `*.Api/` tree exists: **extend that tree** — do not invent `Backend/` or `app/api/**/route.ts`.
- Otherwise create `Backend/` — ASP.NET Core host with `Program.cs`, SDK-style `.csproj` (net8/net9), appsettings, Controllers or Minimal APIs.

## Required pieces

- Entry: `Program.cs` (Kestrel, DI, endpoints)
- SDK-style project file
- `appsettings.json` + Development — connection strings as placeholders (no real secrets)
- Controllers or Minimal APIs (health + domain endpoints)
- Models / DTOs when the brief names data
- EF Core / Npgsql + Migrations when PostgreSQL is in the brief

## When React / Vite client is a sibling (`TrackRouts.Client/`)

- Do **not** own `TrackRouts.Client/**` or `app/**/page.tsx` — that is Rae's card
- Expose CORS / JSON APIs the frontend can call
- Document base URL in a short README under the Api folder

## Done

- `dotnet build` succeeds when the VM has the SDK
- Primary ship path: existing `*.Api/Program.cs` or `Backend/Program.cs`
- Commit + PR with real .cs / .csproj files
- Do not write `app/api/**/route.ts` or `spec/api.openapi.yaml` for a .NET ticket
