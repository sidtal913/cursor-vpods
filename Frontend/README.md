# Frontend (React PWA)

Minimal React hello page with PWA manifest and service worker registration.

## Prerequisites

- Node.js 20+
- npm 10+

## Install

```bash
cd Frontend
npm install
```

## Development

```bash
npm run dev
```

Open [http://localhost:5173](http://localhost:5173). The dev server registers the service worker when supported.

## Production build

```bash
npm run build
npm run preview
```

The production build emits a web app manifest and service worker via `vite-plugin-pwa`.

## PWA

- Manifest: generated at build time (`manifest.webmanifest`)
- Service worker: registered in `src/main.tsx` via `virtual:pwa-register`
- Icons: `public/pwa-icon.svg`

Installability requires HTTPS or `localhost`.

## Backend API (optional)

When the ASP.NET backend is running, it exposes `GET /api/hello` with CORS for `http://localhost:5173`. This hello page is intentionally static; wire API calls in a later ticket if needed.
