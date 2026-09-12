import './App.css'

function App() {
  return (
    <main className="hello-shell" aria-labelledby="hello-heading">
      <div className="hello-shell__backdrop" aria-hidden="true" />
      <div className="hello-shell__content">
        <p className="hello-shell__eyebrow">React PWA</p>
        <h1 id="hello-heading" className="hello-shell__title">
          Hello
        </h1>
        <p className="hello-shell__status">Shell ready — installable when served over HTTPS or localhost.</p>
      </div>
    </main>
  )
}

export default App
