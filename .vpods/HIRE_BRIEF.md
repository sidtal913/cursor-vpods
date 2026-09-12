# Hire brief
Project: Self-hosted .NET web application
Hire agent: knox
Jira: PP-1
Task id: task_91d4286d
Title: Backend: .NET self-hosted API + PostgreSQL
Shape: contract → Backend/Program.cs
## Description
Ship a complete ASP.NET Core (self-hosted) API under Backend/ — Program.cs, .csproj, appsettings, Controllers/Minimal APIs, health endpoint, and PostgreSQL wiring when named. Read .vpods/CRAFT_DOTNET.md when present. Not the React UI.
Include connection/config stubs and a minimal health or hello endpoint when greenfield.
Do not rewrite frontend pages.
Parent brief:
Create a self-hosted .NET web application with the following configuration:
Create a self-hosted .NET web application with the following configuration:

- Backend: http://ASP.NET  Core (self-hosted, not serverless)
- Frontend: React (plain React — do not use Next.js or any other meta-framework)
- Database: PostgreSQL
- The frontend must be PWA-compatible (installable, has a manifest and service worker)
- The frontend should be minimal: a single "Hello" page only. Do not add additional pages, navigation, hero sections, or marketing content.

## Acceptance criteria
- Frontend code is complete and present in the repository
- Backend code is complete and present in the repository
- Instructions are included (in a README) for how to build and run both the frontend and backend locally
- The backend connects to PostgreSQL (a docker-compose file for local Postgres is acceptable)
- No unrequested frameworks, pages, or features are added beyond what is specified above
## Acceptance criteria
- Backend project builds (`dotnet build` when SDK available).
- PostgreSQL (or named DB) config documented when required.
- At least one runnable API endpoint when the brief calls for it.
- Primary path Backend/Program.cs with real supporting .cs files.
## Rules
- Read `.vpods/FRONTEND_AGENT.md` (frontend), `.vpods/PROJECT.md`, `.vpods/CRAFT_*.md` (packed craft grammar), `.vpods/DESIGN_PACK.md` when present, and Brand Kit when present before writing code.
- Stay on this ticket's lane. Do not rewrite sibling hire pages/APIs unless required for integration.
- Ship a complete artifact for this shape — not a stub or question.
- Backend: follow `.vpods/CRAFT_DOTNET.md` — ASP.NET under `Backend/`.
