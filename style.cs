/* ==========================================================
   Nuance | AI Text Analysis Platform | Modern Glassmorphism Theme
   ==========================================================*/

/* ===========================
   VARIABLES & RESET
=========================== */
:root {
    --bg: #06070c;
    --bg-secondary: #0d1018;
    --card: rgba(18, 22, 34, 0.82);
    --card-hover: rgba(24, 28, 42, 0.9);
    --border: rgba(255, 255, 255, 0.06);
    --border-light: rgba(255, 255, 255, 0.12);
    --primary: #6366f1;
    --primary-light: #818cf8;
    --primary-dark: #4338ca;
    --accent: #8b5cf6;
    --success: #22c55e;
    --warning: #f59e0b;
    --danger: #ef4444;
    --text: #f8fafc;
    --text-light: #cbd5e1;
    --muted: #94a3b8;
    --radius: 22px;
    --shadow: 0 15px 45px rgba(0, 0, 0, 0.35);
    --transition: 0.35s cubic-bezier(0.4, 0, 0.2, 1);
}

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

html {
    scroll-behavior: smooth;
    background: var(--bg);
}

body {
    font-family: "Inter", system-ui, sans-serif;
    background: 
        radial-gradient(circle at top, #4338ca20 0%, transparent 40%),
        radial-gradient(circle at bottom right, #8b5cf620 0%, transparent 45%),
        linear-gradient(180deg, #07090f, #05060a);
    color: var(--text);
    overflow-x: hidden;
    min-height: 100vh;
}

/* ===========================
   CUSTOM SCROLLBAR
=========================== */
::-webkit-scrollbar { width: 10px; }
::-webkit-scrollbar-track { background: #090b11; }
::-webkit-scrollbar-thumb { background: #2d3345; border-radius: 100px; }
::-webkit-scrollbar-thumb:hover { background: #454d66; }

/* ===========================
   BACKGROUND ANIMATIONS
=========================== */
.background-glow {
    position: fixed;
    width: 450px;
    height: 450px;
    border-radius: 50%;
    filter: blur(140px);
    opacity: 0.18;
    z-index: -1;
    animation: floatBlob 14s ease-in-out infinite;
}

.glow-1 { top: -180px; left: -120px; background: #6366f1; }
.glow-2 { right: -180px; bottom: -160px; background: #8b5cf6; animation-delay: 4s; }

/* ===========================
   LAYOUT & HEADER
=========================== */
.container {
    width: min(1200px, 92%);
    margin: auto;
    padding: 70px 0;
}

.app-header {
    text-align: center;
    margin-bottom: 60px;
    animation: fadeUp 0.8s ease;
}

.logo {
    width: 90px;
    height: 90px;
    margin: auto;
    display: grid;
    place-items: center;
    border-radius: 50%;
    font-size: 2.4rem;
    background: linear-gradient(145deg, rgba(99, 102, 241, 0.15), rgba(139, 92, 246, 0.12));
    border: 1px solid rgba(255, 255, 255, 0.08);
    backdrop-filter: blur(18px);
    box-shadow: var(--shadow);
    margin-bottom: 24px;
    animation: floatLogo 5s ease-in-out infinite;
}

.badge {
    display: inline-flex;
    align-items: center;
    justify-content: center;
    gap: 8px;
    padding: 8px 18px;
    border-radius: 999px;
    background: rgba(99, 102, 241, 0.12);
    border: 1px solid rgba(99, 102, 241, 0.18);
    color: #b7bcff;
    font-size: 0.72rem;
    text-transform: uppercase;
    font-weight: 700;
    letter-spacing: 0.12em;
}

.app-header h1 {
    margin-top: 25px;
    font-size: clamp(3rem, 6vw, 5rem);
    font-weight: 800;
    line-height: 1;
    letter-spacing: -0.05em;
    background: linear-gradient(135deg, #ffffff, #dbeafe, #818cf8);
    -webkit-background-clip: text;
    -webkit-text-fill-color: transparent;
}

.app-header p {
    width: min(700px, 100%);
    margin: 22px auto 0;
    color: var(--muted);
    line-height: 1.9;
    font-size: 1.08rem;
}

/* ===========================
   GLASS CARDS
=========================== */
.input-card, .analysis-card, .feature-card {
    background: var(--card);
    border: 1px solid var(--border);
    backdrop-filter: blur(20px);
    border-radius: var(--radius);
    box-shadow: var(--shadow);
    transition: var(--transition);
    position: relative;
    overflow: hidden;
}

.input-card::before, .analysis-card::before, .feature-card::before {
    content: "";
    position: absolute;
    inset: 0;
    background: linear-gradient(145deg, rgba(255, 255, 255, 0.03), transparent 45%);
    pointer-events: none;
}

.input-card::after, .analysis-card::after {
    content: "";
    position: absolute;
    inset: 0;
    padding: 1px;
    border-radius: inherit;
    background: linear-gradient(135deg, rgba(99, 102, 241, 0.28), transparent, rgba(139, 92, 246, 0.22));
    -webkit-mask: linear-gradient(#fff 0 0) content-box, linear-gradient(#fff 0 0);
    -webkit-mask-composite: xor;
    mask-composite: exclude;
    pointer-events: none;
}

.input-card:hover, .analysis-card:hover, .feature-card:hover {
    transform: translateY(-5px);
    background: var(--card-hover);
    border-color: var(--border-light);
}

.feature-card:hover { box-shadow: 0 22px 45px rgba(0, 0, 0, 0.45); cursor: default; }
.feature-card:hover h3 { color: var(--primary-light); }

.input-card, .analysis-card { padding: 34px; margin-bottom: 34px; }
.input-card { animation: fadeUp 0.9s ease; }
.analysis-card { animation: fadeUp 1s ease; }

.section-title {
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin-bottom: 25px;
}

.section-title h2 { font-size: 1.35rem; letter-spacing: -0.02em; }
#wordCounter { color: var(--muted); font-size: 0.9rem; }

/* ===========================
   INPUTS & TEXTAREA
=========================== */
.textarea-wrapper { position: relative; }

#userInput {
    width: 100%;
    min-height: 260px;
    resize: vertical;
    border: none;
    outline: none;
    border-radius: 18px;
    padding: 22px;
    background: rgba(8, 10, 18, 0.55);
    color: var(--text);
    font-size: 1rem;
    line-height: 1.8;
    border: 1px solid transparent;
    transition: var(--transition);
}

#userInput::placeholder { color: #667085; }
#userInput:focus {
    border-color: var(--primary);
    box-shadow: 0 0 0 4px rgba(99, 102, 241, 0.18);
    background: rgba(12, 15, 25, 0.8);
}

/* ===========================
   BUTTONS
=========================== */
.button-row {
    display: flex;
    justify-content: flex-end;
    align-items: center;
    gap: 16px;
    margin-top: 24px;
    flex-wrap: wrap;
}

button {
    transition: transform 0.25s, background 0.25s, box-shadow 0.25s;
}

button:focus-visible, textarea:focus-visible { outline: none; }
button:hover { transform: translateY(-2px); }

.primary-btn {
    border: none;
    cursor: pointer;
    padding: 15px 28px;
    border-radius: 14px;
    font-weight: 700;
    font-size: 1rem;
    color: white;
    background: linear-gradient(135deg, var(--primary), var(--primary-dark));
    box-shadow: 0 10px 30px rgba(99, 102, 241, 0.35);
    position: relative;
    overflow: hidden;
}

.primary-btn:hover { box-shadow: 0 18px 35px rgba(99, 102, 241, 0.45); }
.primary-btn:active { transform: scale(0.97); }
.primary-btn:disabled { opacity: 0.65; cursor: not-allowed; }

.primary-btn::before {
    content: "";
    position: absolute;
    top: 0;
    left: -120%;
    width: 60%;
    height: 100%;
    background: linear-gradient(90deg, transparent, rgba(255, 255, 255, 0.35), transparent);
    transform: skewX(-25deg);
}

.primary-btn:hover::before { animation: shine 0.8s ease; }

.secondary-btn {
    border: none;
    cursor: pointer;
    padding: 15px 24px;
    border-radius: 14px;
    color: var(--text-light);
    background: rgba(255, 255, 255, 0.05);
    border: 1px solid rgba(255, 255, 255, 0.06);
}

.secondary-btn:hover { background: rgba(255, 255, 255, 0.08); }

.output-buttons { display: flex; gap: 12px; }

.icon-btn {
    border: none;
    cursor: pointer;
    padding: 10px 18px;
    border-radius: 12px;
    background: rgba(255, 255, 255, 0.05);
    color: var(--text-light);
}

.icon-btn:hover { background: rgba(99, 102, 241, 0.12); color: white; }

/* ===========================
   UI STATES (LOADING, EMPTY)
=========================== */
.hidden { display: none !important; }

.loading {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    gap: 20px;
    padding: 80px 20px;
    animation: fadeIn 0.5s;
}

.loading p { color: var(--muted); font-size: 1rem; }

.spinner {
    width: 54px;
    height: 54px;
    border-radius: 50%;
    border: 5px solid rgba(255, 255, 255, 0.08);
    border-top: 5px solid var(--primary);
    animation: spin 0.8s linear infinite;
}

.empty-state {
    text-align: center;
    padding: 90px 30px;
    animation: fadeIn 0.5s;
}

.empty-icon { font-size: 4rem; margin-bottom: 18px; }
.empty-state h3 { margin-bottom: 14px; font-size: 1.5rem; }
.empty-state p { color: var(--muted); line-height: 1.9; max-width: 550px; margin: auto; }

/* ===========================
   AI OUTPUT & TYPOGRAPHY
=========================== */
.output { animation: fadeIn 0.4s; line-height: 1.9; color: var(--text-light); }
.output h1, .output h2, .output h3 { margin: 35px 0 16px; color: white; letter-spacing: -0.02em; }
.output p { margin-bottom: 20px; }
.output ul { margin-left: 24px; margin-bottom: 24px; }
.output li { margin-bottom: 10px; }
.output li::marker { color: var(--primary); }
.output strong { color: white; }
.output hr { border: none; border-top: 1px solid rgba(255, 255, 255, 0.08); margin: 30px 0; }
.output a { color: #9ea6ff; text-decoration: none; transition: 0.25s; }
.output a:hover { color: white; text-decoration: underline; }

.output pre {
    overflow: auto;
    padding: 18px;
    border-radius: 14px;
    background: rgba(0, 0, 0, 0.25);
    margin: 25px 0;
}

.output code { font-family: Consolas, monospace; color: #b7bcff; }
.output blockquote {
    margin: 25px 0;
    padding: 18px 24px;
    border-left: 4px solid var(--primary);
    background: rgba(255, 255, 255, 0.03);
    color: var(--text-light);
}

/* ===========================
   FEATURES SECTION
=========================== */
.features-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
    gap: 22px;
    margin-top: 45px;
    animation: fadeUp 1.15s ease;
}

.feature-card { padding: 28px; }
.feature-card h3 { font-size: 1.15rem; margin-bottom: 12px; transition: 0.3s; }
.feature-card p { color: var(--muted); line-height: 1.8; }

/* ===========================
   FOOTER
=========================== */
footer {
    margin-top: 70px;
    padding: 25px 0;
    text-align: center;
    color: var(--muted);
    font-size: 0.95rem;
}

::selection { background: rgba(99, 102, 241, 0.35); color: white; }

/* ===========================
   ANIMATIONS
=========================== */
@keyframes floatBlob {
    0%, 100% { transform: translateY(0) scale(1); }
    50% { transform: translateY(40px) scale(1.08); }
}
@keyframes fadeIn {
    from { opacity: 0; transform: translateY(12px); }
    to { opacity: 1; transform: translateY(0); }
}
@keyframes fadeUp {
    from { opacity: 0; transform: translateY(18px); }
    to { opacity: 1; transform: translateY(0); }
}
@keyframes spin { to { transform: rotate(360deg); } }
@keyframes shine { to { left: 160%; } }
@keyframes floatLogo {
    0%, 100% { transform: translateY(0); }
    50% { transform: translateY(-10px); }
}

/* ===========================
   MEDIA QUERIES
=========================== */
@media(max-width: 900px) {
    .container { width: 94%; }
    .input-card, .analysis-card { padding: 24px; }
    .button-row { justify-content: center; }
    .output-buttons { flex-wrap: wrap; }
    .section-title { flex-direction: column; align-items: flex-start; gap: 12px; }
    .app-header h1 { font-size: 3rem; }
}

@media(max-width: 600px) {
    body { font-size: 15px; }
    .logo { width: 74px; height: 74px; font-size: 2rem; }
    .badge { font-size: 0.65rem; }
    .app-header h1 { font-size: 2.4rem; }
    .app-header p { font-size: 0.95rem; }
    #userInput { min-height: 220px; padding: 18px; }
    .button-row { flex-direction: column; }
    .primary-btn, .secondary-btn, .output-buttons { width: 100%; }
    .icon-btn { flex: 1; }
    .features-grid { grid-template-columns: 1fr; }
}

@media(min-width: 1500px) {
    .container { max-width: 1350px; }
}

@media(prefers-reduced-motion: reduce) {
    * { animation: none !important; transition: none !important; scroll-behavior: auto; }
}

@supports(backdrop-filter: blur(20px)) {
    .input-card, .analysis-card, .feature-card { backdrop-filter: blur(22px); }
}