# Hire brief
Project: Self-hosted .NET web application
Hire agent: rae
Jira: PP-4
Task id: task_b3dc00b7
Title: Frontend: Hello page (PWA shell)
Shape: page → app/page.tsx
## Description
Ship the React hello page only — not the .NET API or database.
Include PWA basics (web manifest + service worker registration) when the app shell allows.
Do not create ASP.NET / .csproj / PostgreSQL files.
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
- Hello page renders.
- PWA manifest present.
- Build/run notes for the frontend only (or leave to the docs ticket).
## Rules
- Read `.vpods/FRONTEND_AGENT.md` (frontend), `.vpods/PROJECT.md`, `.vpods/CRAFT_*.md` (packed craft grammar), `.vpods/DESIGN_PACK.md` when present, and Brand Kit when present before writing code.
- Stay on this ticket's lane. Do not rewrite sibling hire pages/APIs unless required for integration.
- Ship a complete artifact for this shape — not a stub or question.
- Frontend: replicate attached mockups under `public/design-refs/` (composition, photography, bands). Labels on the mockup are direction, not a copy deck.
