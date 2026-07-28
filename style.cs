/* ==========================================================
   Nuance | AI Text Analysis Platform | Refined Glassmorphism Theme
   ========================================================== */

/* ==========================================================
   1. VARIABLES & SYSTEM DEFAULTS
   ========================================================== */
:root {
    /* Color Palette */
    --bg: #06070c;
    --bg-secondary: #0d1018;
    --card: rgba(18, 22, 34, 0.75);
    --card-hover: rgba(24, 28, 44, 0.88);
    --border: rgba(255, 255, 255, 0.07);
    --border-light: rgba(255, 255, 255, 0.14);
    
    /* Brand Accent Colors */
    --primary: #6366f1;
    --primary-light: #818cf8;
    --primary-dark: #4338ca;
    --accent: #8b5cf6;
    --accent-glow: rgba(139, 92, 246, 0.25);
    
    /* Feedback Colors */
    --success: #22c55e;
    --warning: #f59e0b;
    --danger: #ef4444;
    
    /* Typography Colors */
    --text: #f8fafc;
    --text-light: #cbd5e1;
    --muted: #94a3b8;
    
    /* Design Tokens */
    --radius-lg: 22px;
    --radius-md: 14px;
    --radius-sm: 8px;
    --shadow-main: 0 20px 50px rgba(0, 0, 0, 0.45);
    --shadow-glow: 0 10px 30px rgba(99, 102, 241, 0.3);
    --transition: 0.3s cubic-bezier(0.16, 1, 0.3, 1);
}

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

html {
    scroll-behavior: smooth;
    background: var(--bg);
    color-scheme: dark;
}

body {
    font-family: "Inter", system-ui, -apple-system, BlinkMacSystemFont, sans-serif;
    background: 
        radial-gradient(circle at 50% 0%, rgba(67, 56, 202, 0.18) 0%, transparent 50%),
        radial-gradient(circle at 85% 85%, rgba(139, 92, 246, 0.15) 0%, transparent 50%),
        linear-gradient(180deg, #07090f 0%, #05060a 100%);
    color: var(--text);
    overflow-x: hidden;
    min-height: 100vh;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
}

::selection {
    background: rgba(99, 102, 241, 0.4);
    color: #ffffff;
}

/* ==========================================================
   2. CUSTOM SCROLLBAR
   ========================================================== */
::-webkit-scrollbar { 
    width: 8px; 
}
::-webkit-scrollbar-track { 
    background: #06070c; 
}
::-webkit-scrollbar-thumb { 
    background: #1e2436; 
    border-radius: 99px;
    border: 2px solid #06070c;
}
::-webkit-scrollbar-thumb:hover { 
    background: var(--primary-dark); 
}

/* ==========================================================
   3. BACKGROUND AMBIENT ANIMATIONS (GPU OPTIMIZED)
   ========================================================== */
.background-glow {
    position: fixed;
    width: 500px;
    height: 500px;
    border-radius: 50%;
    filter: blur(150px);
    opacity: 0.16;
    z-index: -1;
    pointer-events: none;
    will-change: transform;
    animation: floatBlob 16s ease-in-out infinite alternate;
}

.glow-1 { 
    top: -200px; 
    left: -150px; 
    background: var(--primary); 
}

.glow-2 { 
    right: -200px; 
    bottom: -180px; 
    background: var(--accent); 
    animation-delay: -6s; 
}

/* ==========================================================
   4. LAYOUT & HEADER
   ========================================================== */
.container {
    width: min(1200px, 90%);
    margin: 0 auto;
    padding: 60px 0 80px;
}

.app-header {
    text-align: center;
    margin-bottom: 50px;
    animation: fadeUp 0.8s cubic-bezier(0.16, 1, 0.3, 1);
}

.logo {
    width: 84px;
    height: 84px;
    margin: 0 auto 24px;
    display: grid;
    place-items: center;
    border-radius: 50%;
    font-size: 2.2rem;
    background: linear-gradient(145deg, rgba(99, 102, 241, 0.2), rgba(139, 92, 246, 0.1));
    border: 1px solid rgba(255, 255, 255, 0.12);
    backdrop-filter: blur(16px);
    box-shadow: var(--shadow-main);
    will-change: transform;
    animation: floatLogo 6s ease-in-out infinite;
}

.badge {
    display: inline-flex;
    align-items: center;
    justify-content: center;
    gap: 8px;
    padding: 6px 16px;
    border-radius: 999px;
    background: rgba(99, 102, 241, 0.1);
    border: 1px solid rgba(99, 102, 241, 0.25);
    color: #c7d2fe;
    font-size: 0.75rem;
    text-transform: uppercase;
    font-weight: 700;
    letter-spacing: 0.1em;
}

.app-header h1 {
    margin-top: 20px;
    font-size: clamp(2.8rem, 5.5vw, 4.5rem);
    font-weight: 800;
    line-height: 1.05;
    letter-spacing: -0.04em;
    background: linear-gradient(135deg, #ffffff 30%, #c7d2fe 70%, #818cf8 100%);
    -webkit-background-clip: text;
    -webkit-text-fill-color: transparent;
}

.app-header p {
    width: min(680px, 100%);
    margin: 18px auto 0;
    color: var(--muted);
    line-height: 1.8;
    font-size: 1.05rem;
}

/* ==========================================================
   5. GLASS CARDS & CONTAINERS
   ========================================================== */
.input-card, .analysis-card, .feature-card {
    background: var(--card);
    border: 1px solid var(--border);
    backdrop-filter: blur(24px);
    -webkit-backdrop-filter: blur(24px);
    border-radius: var(--radius-lg);
    box-shadow: var(--shadow-main);
    transition: var(--transition);
    position: relative;
    overflow: hidden;
}

/* Glass Highlight Overlay */
.input-card::before, .analysis-card::before, .feature-card::before {
    content: "";
    position: absolute;
    inset: 0;
    background: linear-gradient(135deg, rgba(255, 255, 255, 0.05), transparent 40%);
    pointer-events: none;
}

/* Specular Border Trace */
.input-card::after, .analysis-card::after {
    content: "";
    position: absolute;
    inset: 0;
    padding: 1px;
    border-radius: inherit;
    background: linear-gradient(135deg, rgba(99, 102, 241, 0.3), transparent 60%, rgba(139, 92, 246, 0.2));
    -webkit-mask: linear-gradient(#fff 0 0) content-box, linear-gradient(#fff 0 0);
    -webkit-mask-composite: xor;
    mask-composite: exclude;
    pointer-events: none;
}

.input-card:hover, .analysis-card:hover, .feature-card:hover {
    background: var(--card-hover);
    border-color: var(--border-light);
    transform: translateY(-3px);
}

.input-card, .analysis-card { 
    padding: 32px; 
    margin-bottom: 32px; 
    animation: fadeUp 0.8s cubic-bezier(0.16, 1, 0.3, 1);
}

.section-title {
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin-bottom: 20px;
}

.section-title h2 { 
    font-size: 1.3rem; 
    font-weight: 700;
    letter-spacing: -0.02em; 
}

#wordCounter { 
    color: var(--muted); 
    font-size: 0.85rem; 
    font-weight: 500;
}

/* ==========================================================
   6. TEXTAREA & FORM INPUTS
   ========================================================== */
.textarea-wrapper { 
    position: relative; 
}

#userInput {
    width: 100%;
    min-height: 240px;
    resize: vertical;
    outline: none;
    border-radius: var(--radius-md);
    padding: 20px;
    background: rgba(6, 8, 14, 0.6);
    color: var(--text);
    font-family: inherit;
    font-size: 0.98rem;
    line-height: 1.7;
    border: 1px solid var(--border);
    transition: var(--transition);
}

#userInput::placeholder { 
    color: #475569; 
}

#userInput:focus {
    border-color: var(--primary-light);
    box-shadow: 0 0 0 4px rgba(99, 102, 241, 0.15);
    background: rgba(10, 13, 22, 0.85);
}

/* ==========================================================
   7. BUTTONS & ACTIONS
   ========================================================== */
.button-row {
    display: flex;
    justify-content: flex-end;
    align-items: center;
    gap: 14px;
    margin-top: 24px;
    flex-wrap: wrap;
}

button {
    font-family: inherit;
    border: none;
    cursor: pointer;
    border-radius: var(--radius-md);
    transition: var(--transition);
    display: inline-flex;
    align-items: center;
    justify-content: center;
    gap: 8px;
}

button:focus-visible, textarea:focus-visible {
    outline: 2px solid var(--primary-light);
    outline-offset: 2px;
}

.primary-btn {
    padding: 14px 28px;
    font-weight: 600;
    font-size: 0.95rem;
    color: #ffffff;
    background: linear-gradient(135deg, var(--primary), var(--primary-dark));
    box-shadow: var(--shadow-glow);
    position: relative;
    overflow: hidden;
}

.primary-btn:hover {
    transform: translateY(-2px);
    box-shadow: 0 14px 35px rgba(99, 102, 241, 0.45);
}

.primary-btn:active { 
    transform: translateY(0) scale(0.98); 
}

.primary-btn:disabled { 
    opacity: 0.5; 
    cursor: not-allowed; 
    transform: none;
    box-shadow: none;
}

/* Shimmer Light Reflection */
.primary-btn::before {
    content: "";
    position: absolute;
    top: 0;
    left: -120%;
    width: 60%;
    height: 100%;
    background: linear-gradient(90deg, transparent, rgba(255, 255, 255, 0.3), transparent);
    transform: skewX(-20deg);
}

.primary-btn:hover::before { 
    animation: shine 0.75s ease-in-out; 
}

.secondary-btn {
    padding: 14px 22px;
    font-size: 0.95rem;
    font-weight: 500;
    color: var(--text-light);
    background: rgba(255, 255, 255, 0.04);
    border: 1px solid var(--border);
}

.secondary-btn:hover {
    background: rgba(255, 255, 255, 0.08);
    color: #ffffff;
    transform: translateY(-2px);
}

.output-buttons { 
    display: flex; 
    gap: 10px; 
}

.icon-btn {
    padding: 10px 16px;
    font-size: 0.88rem;
    font-weight: 500;
    background: rgba(255, 255, 255, 0.04);
    border: 1px solid var(--border);
    color: var(--text-light);
}

.icon-btn:hover { 
    background: rgba(99, 102, 241, 0.15); 
    border-color: rgba(99, 102, 241, 0.3);
    color: #ffffff; 
}

/* ==========================================================
   8. UI STATES (LOADING, EMPTY)
   ========================================================== */
.hidden { 
    display: none !important; 
}

.loading {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    gap: 18px;
    padding: 70px 20px;
    animation: fadeIn 0.4s ease;
}

.loading p { 
    color: var(--muted); 
    font-size: 0.95rem; 
}

.spinner {
    width: 48px;
    height: 48px;
    border-radius: 50%;
    border: 4px solid rgba(255, 255, 255, 0.08);
    border-top-color: var(--primary-light);
    animation: spin 0.8s linear infinite;
}

.empty-state {
    text-align: center;
    padding: 75px 20px;
    animation: fadeIn 0.4s ease;
}

.empty-icon { 
    font-size: 3.5rem; 
    margin-bottom: 16px; 
    display: block;
}

.empty-state h3 { 
    margin-bottom: 10px; 
    font-size: 1.35rem; 
    font-weight: 700;
}

.empty-state p { 
    color: var(--muted); 
    line-height: 1.8; 
    max-width: 520px; 
    margin: 0 auto; 
    font-size: 0.95rem;
}

/* ==========================================================
   9. DYNAMIC AI OUTPUT TYPOGRAPHY
   ========================================================== */
.output { 
    animation: fadeIn 0.4s ease; 
    line-height: 1.8; 
    color: var(--text-light); 
}

.output h1, .output h2, .output h3 { 
    margin: 32px 0 14px; 
    color: #ffffff; 
    letter-spacing: -0.02em; 
    font-weight: 700;
}

.output h2 { font-size: 1.4rem; }
.output h3 { font-size: 1.15rem; }

.output p { margin-bottom: 18px; }

.output ul, .output ol { 
    margin-left: 20px; 
    margin-bottom: 20px; 
}

.output li { margin-bottom: 8px; }
.output li::marker { color: var(--primary-light); }

.output strong { 
    color: #ffffff; 
    font-weight: 600;
}

.output hr { 
    border: none; 
    border-top: 1px solid var(--border); 
    margin: 28px 0; 
}

.output a { 
    color: var(--primary-light); 
    text-decoration: none; 
    transition: var(--transition); 
}

.output a:hover { 
    color: #ffffff; 
    text-decoration: underline; 
}

.output pre {
    overflow-x: auto;
    padding: 16px;
    border-radius: var(--radius-md);
    background: rgba(0, 0, 0, 0.4);
    border: 1px solid var(--border);
    margin: 20px 0;
}

.output code { 
    font-family: "Fira Code", Consolas, Monaco, monospace; 
    font-size: 0.9rem;
    color: #c7d2fe; 
}

.output blockquote {
    margin: 20px 0;
    padding: 16px 20px;
    border-left: 3px solid var(--primary);
    border-radius: 0 var(--radius-md) var(--radius-md) 0;
    background: rgba(255, 255, 255, 0.02);
    color: var(--text-light);
    font-style: italic;
}

/* ==========================================================
   10. FEATURES GRID
   ========================================================== */
.features-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(260px, 1fr));
    gap: 20px;
    margin-top: 40px;
    animation: fadeUp 1s cubic-bezier(0.16, 1, 0.3, 1);
}

.feature-card { 
    padding: 28px; 
}

.feature-card h3 { 
    font-size: 1.1rem; 
    font-weight: 600;
    margin-bottom: 10px; 
    color: var(--text);
    transition: var(--transition); 
}

.feature-card p { 
    color: var(--muted); 
    line-height: 1.7; 
    font-size: 0.92rem;
}

.feature-card:hover h3 { 
    color: var(--primary-light); 
}

/* ==========================================================
   11. FOOTER
   ========================================================== */
footer {
    margin-top: 60px;
    padding: 20px 0;
    text-align: center;
    color: var(--muted);
    font-size: 0.9rem;
}

/* ==========================================================
   12. KEYFRAME ANIMATIONS
   ========================================================== */
@keyframes floatBlob {
    0% { transform: translate3d(0, 0, 0) scale(1); }
    100% { transform: translate3d(30px, 40px, 0) scale(1.08); }
}

@keyframes floatLogo {
    0%, 100% { transform: translate3d(0, 0, 0); }
    50% { transform: translate3d(0, -8px, 0); }
}

@keyframes fadeIn {
    from { opacity: 0; transform: translateY(8px); }
    to { opacity: 1; transform: translateY(0); }
}

@keyframes fadeUp {
    from { opacity: 0; transform: translateY(20px); }
    to { opacity: 1; transform: translateY(0); }
}

@keyframes spin { 
    to { transform: rotate(360deg); } 
}

@keyframes shine { 
    to { left: 160%; } 
}

/* ==========================================================
   13. RESPONSIVE DESIGN (MEDIA QUERIES)
   ========================================================== */
@media (max-width: 900px) {
    .container { width: 92%; }
    .input-card, .analysis-card { padding: 24px; }
    .button-row { justify-content: stretch; }
    .primary-btn, .secondary-btn { flex: 1; }
    .section-title { flex-direction: column; align-items: flex-start; gap: 8px; }
}

@media (max-width: 600px) {
    body { font-size: 15px; }
    .logo { width: 70px; height: 70px; font-size: 1.8rem; }
    .app-header h1 { font-size: 2.2rem; }
    .app-header p { font-size: 0.92rem; }
    #userInput { min-height: 200px; padding: 16px; }
    .button-row { flex-direction: column; width: 100%; }
    .primary-btn, .secondary-btn, .output-buttons { width: 100%; }
    .icon-btn { flex: 1; }
    .features-grid { grid-template-columns: 1fr; }
}

@media (prefers-reduced-motion: reduce) {
    *, ::before, ::after { 
        animation: none !important; 
        transition: none !important; 
        scroll-behavior: auto !important; 
    }
}