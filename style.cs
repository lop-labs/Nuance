/* ==========================================================
   Nuance
   AI Text Analysis Platform
   Modern Glassmorphism Theme

   Part 1
   ==========================================================*/


/* ===========================
   VARIABLES
=========================== */

:root{

    --bg:#06070c;

    --bg-secondary:#0d1018;

    --card:rgba(18,22,34,.82);

    --card-hover:rgba(24,28,42,.9);

    --border:rgba(255,255,255,.06);

    --border-light:rgba(255,255,255,.12);

    --primary:#6366f1;

    --primary-light:#818cf8;

    --primary-dark:#4338ca;

    --accent:#8b5cf6;

    --success:#22c55e;

    --warning:#f59e0b;

    --danger:#ef4444;

    --text:#f8fafc;

    --text-light:#cbd5e1;

    --muted:#94a3b8;

    --radius:22px;

    --shadow:

        0 15px 45px rgba(0,0,0,.35);

    --transition:

        .35s cubic-bezier(.4,0,.2,1);

}



/* ===========================
   RESET
=========================== */

*{

    margin:0;

    padding:0;

    box-sizing:border-box;

}

html{

    scroll-behavior:smooth;

}

body{

    font-family:

        "Inter",

        system-ui,

        sans-serif;

    background:var(--bg);

    color:var(--text);

    overflow-x:hidden;

    min-height:100vh;

}



/* ===========================
   CUSTOM SCROLLBAR
=========================== */

::-webkit-scrollbar{

    width:10px;

}

::-webkit-scrollbar-track{

    background:#090b11;

}

::-webkit-scrollbar-thumb{

    background:#2d3345;

    border-radius:100px;

}

::-webkit-scrollbar-thumb:hover{

    background:#454d66;

}



/* ===========================
   BACKGROUND
=========================== */

body{

    background:

        radial-gradient(circle at top,#4338ca20 0%,transparent 40%),

        radial-gradient(circle at bottom right,#8b5cf620 0%,transparent 45%),

        linear-gradient(

            180deg,

            #07090f,

            #05060a

        );

}



/* Floating blobs */

.background-glow{

    position:fixed;

    width:450px;

    height:450px;

    border-radius:50%;

    filter:blur(140px);

    opacity:.18;

    z-index:-1;

    animation:

        floatBlob 14s ease-in-out infinite;

}

.glow-1{

    top:-180px;

    left:-120px;

    background:#6366f1;

}

.glow-2{

    right:-180px;

    bottom:-160px;

    background:#8b5cf6;

    animation-delay:4s;

}



/* ===========================
   MAIN CONTAINER
=========================== */

.container{

    width:min(1200px,92%);

    margin:auto;

    padding:

        70px 0;

}



/* ===========================
   HEADER
=========================== */

.app-header{

    text-align:center;

    margin-bottom:60px;

}

.logo{

    width:90px;

    height:90px;

    margin:auto;

    display:grid;

    place-items:center;

    border-radius:50%;

    font-size:2.4rem;

    background:

        linear-gradient(

            145deg,

            rgba(99,102,241,.15),

            rgba(139,92,246,.12)

        );

    border:

        1px solid

        rgba(255,255,255,.08);

    backdrop-filter:blur(18px);

    box-shadow:

        var(--shadow);

    margin-bottom:24px;

}

.badge{

    display:inline-flex;

    align-items:center;

    justify-content:center;

    gap:8px;

    padding:

        8px 18px;

    border-radius:999px;

    background:

        rgba(99,102,241,.12);

    border:

        1px solid

        rgba(99,102,241,.18);

    color:#b7bcff;

    font-size:.72rem;

    text-transform:uppercase;

    font-weight:700;

    letter-spacing:.12em;

}

.app-header h1{

    margin-top:25px;

    font-size:

        clamp(3rem,6vw,5rem);

    font-weight:800;

    line-height:1;

    letter-spacing:-.05em;

    background:

        linear-gradient(

            135deg,

            #ffffff,

            #dbeafe,

            #818cf8

        );

    -webkit-background-clip:text;

    -webkit-text-fill-color:transparent;

}

.app-header p{

    width:min(700px,100%);

    margin:

        22px auto 0;

    color:var(--muted);

    line-height:1.9;

    font-size:1.08rem;

}



/* ===========================
   GLASS CARD
=========================== */

.input-card,

.analysis-card,

.feature-card{

    background:

        var(--card);

    border:

        1px solid

        var(--border);

    backdrop-filter:

        blur(20px);

    border-radius:

        var(--radius);

    box-shadow:

        var(--shadow);

    transition:

        var(--transition);

    position:relative;

    overflow:hidden;

}

.input-card::before,

.analysis-card::before,

.feature-card::before{

    content:"";

    position:absolute;

    inset:0;

    background:

        linear-gradient(

            145deg,

            rgba(255,255,255,.03),

            transparent 45%

        );

    pointer-events:none;

}

.input-card:hover,

.analysis-card:hover,

.feature-card:hover{

    transform:

        translateY(-5px);

    background:

        var(--card-hover);

    border-color:

        var(--border-light);

}



/* ===========================
   SECTION TITLES
=========================== */

.section-title{

    display:flex;

    justify-content:space-between;

    align-items:center;

    margin-bottom:25px;

}

.section-title h2{

    font-size:1.35rem;

    letter-spacing:-.02em;

}

#wordCounter{

    color:var(--muted);

    font-size:.9rem;

}



/* ===========================
   SPACING
=========================== */

.input-card,

.analysis-card{

    padding:34px;

    margin-bottom:34px;

}



/* ===========================
   ANIMATIONS
=========================== */

@keyframes floatBlob{

    0%{

        transform:

            translateY(0)

            scale(1);

    }

    50%{

        transform:

            translateY(40px)

            scale(1.08);

    }

    100%{

        transform:

            translateY(0)

            scale(1);

    }

}

@keyframes fadeIn{

    from{

        opacity:0;

        transform:

            translateY(12px);

    }

    to{

        opacity:1;

        transform:

            translateY(0);

    }

}

.hidden{

    display:none !important;

}
/* ==========================================================
   PART 2
   INPUTS • BUTTONS • OUTPUT • LOADING • FEATURES
========================================================== */


/* ===========================
   TEXTAREA
=========================== */

.textarea-wrapper{

    position:relative;

}

#userInput{

    width:100%;

    min-height:260px;

    resize:vertical;

    border:none;

    outline:none;

    border-radius:18px;

    padding:22px;

    background:rgba(8,10,18,.55);

    color:var(--text);

    font-size:1rem;

    line-height:1.8;

    border:1px solid transparent;

    transition:var(--transition);

}

#userInput::placeholder{

    color:#667085;

}

#userInput:focus{

    border-color:var(--primary);

    box-shadow:

        0 0 0 4px rgba(99,102,241,.18);

    background:

        rgba(12,15,25,.8);

}



/* ===========================
   BUTTON ROW
=========================== */

.button-row{

    display:flex;

    justify-content:flex-end;

    align-items:center;

    gap:16px;

    margin-top:24px;

    flex-wrap:wrap;

}



/* ===========================
   PRIMARY BUTTON
=========================== */

.primary-btn{

    border:none;

    cursor:pointer;

    padding:

        15px 28px;

    border-radius:14px;

    font-weight:700;

    font-size:1rem;

    color:white;

    background:

        linear-gradient(

            135deg,

            var(--primary),

            var(--primary-dark)

        );

    transition:

        var(--transition);

    box-shadow:

        0 10px 30px

        rgba(99,102,241,.35);

}

.primary-btn:hover{

    transform:

        translateY(-3px);

    box-shadow:

        0 18px 35px

        rgba(99,102,241,.45);

}

.primary-btn:active{

    transform:scale(.97);

}

.primary-btn:disabled{

    opacity:.65;

    cursor:not-allowed;

}



/* ===========================
   SECONDARY BUTTON
=========================== */

.secondary-btn{

    border:none;

    cursor:pointer;

    padding:

        15px 24px;

    border-radius:14px;

    color:var(--text-light);

    background:

        rgba(255,255,255,.05);

    border:

        1px solid

        rgba(255,255,255,.06);

    transition:

        var(--transition);

}

.secondary-btn:hover{

    transform:

        translateY(-2px);

    background:

        rgba(255,255,255,.08);

}



/* ===========================
   ICON BUTTONS
=========================== */

.output-buttons{

    display:flex;

    gap:12px;

}

.icon-btn{

    border:none;

    cursor:pointer;

    padding:

        10px 18px;

    border-radius:12px;

    background:

        rgba(255,255,255,.05);

    color:var(--text-light);

    transition:var(--transition);

}

.icon-btn:hover{

    background:

        rgba(99,102,241,.12);

    color:white;

}



/* ===========================
   LOADING
=========================== */

.loading{

    display:flex;

    flex-direction:column;

    align-items:center;

    justify-content:center;

    gap:20px;

    padding:80px 20px;

    animation:fadeIn .5s;

}

.loading p{

    color:var(--muted);

    font-size:1rem;

}



/* ===========================
   SPINNER
=========================== */

.spinner{

    width:54px;

    height:54px;

    border-radius:50%;

    border:

        5px solid

        rgba(255,255,255,.08);

    border-top:

        5px solid

        var(--primary);

    animation:

        spin .8s linear infinite;

}

@keyframes spin{

    to{

        transform:rotate(360deg);

    }

}



/* ===========================
   EMPTY STATE
=========================== */

.empty-state{

    text-align:center;

    padding:90px 30px;

    animation:fadeIn .5s;

}

.empty-icon{

    font-size:4rem;

    margin-bottom:18px;

}

.empty-state h3{

    margin-bottom:14px;

    font-size:1.5rem;

}

.empty-state p{

    color:var(--muted);

    line-height:1.9;

    max-width:550px;

    margin:auto;

}



/* ===========================
   AI OUTPUT
=========================== */

.output{

    animation:fadeIn .4s;

    line-height:1.9;

    color:var(--text-light);

}

.output h1,

.output h2,

.output h3{

    margin:

        35px 0 16px;

    color:white;

    letter-spacing:-.02em;

}

.output p{

    margin-bottom:20px;

}

.output ul{

    margin-left:24px;

    margin-bottom:24px;

}

.output li{

    margin-bottom:10px;

}

.output strong{

    color:white;

}

.output hr{

    border:none;

    border-top:

        1px solid

        rgba(255,255,255,.08);

    margin:30px 0;

}



/* ===========================
   FEATURES
=========================== */

.features-grid{

    display:grid;

    grid-template-columns:

        repeat(

            auto-fit,

            minmax(250px,1fr)

        );

    gap:22px;

    margin-top:45px;

}

.feature-card{

    padding:28px;

}

.feature-card h3{

    font-size:1.15rem;

    margin-bottom:12px;

}

.feature-card p{

    color:var(--muted);

    line-height:1.8;

}

.feature-card:hover{

    transform:

        translateY(-8px)

        scale(1.02);

}



/* ===========================
   FOOTER
=========================== */

footer{

    margin-top:70px;

    padding:25px 0;

    text-align:center;

    color:var(--muted);

    font-size:.95rem;

}



/* ===========================
   SELECTION
=========================== */

::selection{

    background:

        rgba(99,102,241,.35);

    color:white;

}



/* ===========================
   FOCUS
=========================== */

button:focus-visible,

textarea:focus-visible{

    outline:none;

}



/* ===========================
   CARD ENTRANCE
=========================== */

.input-card,

.analysis-card,

.feature-card{

    animation:

        fadeIn .6s ease;

}
/* ==========================================================
   PART 3
   RESPONSIVE • MICRO INTERACTIONS • POLISH
========================================================== */


/* ===========================
   GRADIENT BORDER
=========================== */

.input-card::after,
.analysis-card::after{

    content:"";

    position:absolute;

    inset:0;

    padding:1px;

    border-radius:inherit;

    background:

        linear-gradient(

            135deg,

            rgba(99,102,241,.28),

            transparent,

            rgba(139,92,246,.22)

        );

    -webkit-mask:

        linear-gradient(#fff 0 0) content-box,

        linear-gradient(#fff 0 0);

    -webkit-mask-composite:xor;

            mask-composite:exclude;

    pointer-events:none;

}



/* ===========================
   BUTTON GLOW
=========================== */

.primary-btn{

    position:relative;

    overflow:hidden;

}

.primary-btn::before{

    content:"";

    position:absolute;

    top:0;

    left:-120%;

    width:60%;

    height:100%;

    background:

        linear-gradient(

            90deg,

            transparent,

            rgba(255,255,255,.35),

            transparent

        );

    transform:skewX(-25deg);

}

.primary-btn:hover::before{

    animation:

        shine .8s ease;

}

@keyframes shine{

    to{

        left:160%;

    }

}



/* ===========================
   FEATURE CARD ICON LIFT
=========================== */

.feature-card{

    cursor:default;

}

.feature-card h3{

    transition:.3s;

}

.feature-card:hover h3{

    color:var(--primary-light);

}



/* ===========================
   OUTPUT LINKS
=========================== */

.output a{

    color:#9ea6ff;

    text-decoration:none;

    transition:.25s;

}

.output a:hover{

    color:white;

    text-decoration:underline;

}



/* ===========================
   OUTPUT TABLES
=========================== */

.output table{

    width:100%;

    border-collapse:collapse;

    margin:25px 0;

    overflow:hidden;

    border-radius:14px;

}

.output th{

    background:

        rgba(99,102,241,.12);

    color:white;

    text-align:left;

    padding:14px;

}

.output td{

    padding:14px;

    border-top:

        1px solid

        rgba(255,255,255,.06);

}



/* ===========================
   CODE BLOCKS
=========================== */

.output pre{

    overflow:auto;

    padding:18px;

    border-radius:14px;

    background:

        rgba(0,0,0,.25);

    margin:25px 0;

}

.output code{

    font-family:

        Consolas,

        monospace;

    color:#b7bcff;

}



/* ===========================
   BLOCKQUOTES
=========================== */

.output blockquote{

    margin:25px 0;

    padding:18px 24px;

    border-left:

        4px solid

        var(--primary);

    background:

        rgba(255,255,255,.03);

    color:var(--text-light);

}



/* ===========================
   LISTS
=========================== */

.output li::marker{

    color:var(--primary);

}



/* ===========================
   SUBTLE CARD SHADOW
=========================== */

.feature-card:hover{

    box-shadow:

        0 22px 45px rgba(0,0,0,.45);

}



/* ===========================
   FLOATING ANIMATION
=========================== */

.logo{

    animation:

        floatLogo 5s ease-in-out infinite;

}

@keyframes floatLogo{

    0%{

        transform:

            translateY(0);

    }

    50%{

        transform:

            translateY(-10px);

    }

    100%{

        transform:

            translateY(0);

    }

}



/* ===========================
   FADE UP
=========================== */

@keyframes fadeUp{

    from{

        opacity:0;

        transform:

            translateY(18px);

    }

    to{

        opacity:1;

        transform:

            translateY(0);

    }

}

.app-header{

    animation:

        fadeUp .8s ease;

}

.input-card{

    animation:

        fadeUp .9s ease;

}

.analysis-card{

    animation:

        fadeUp 1s ease;

}

.features-grid{

    animation:

        fadeUp 1.15s ease;

}



/* ===========================
   MOBILE
=========================== */

@media(max-width:900px){

.container{

    width:94%;

}

.input-card,

.analysis-card{

    padding:24px;

}

.button-row{

    justify-content:center;

}

.output-buttons{

    flex-wrap:wrap;

}

.section-title{

    flex-direction:column;

    align-items:flex-start;

    gap:12px;

}

.app-header h1{

    font-size:3rem;

}

}



/* ===========================
   SMALL PHONES
=========================== */

@media(max-width:600px){

body{

    font-size:15px;

}

.logo{

    width:74px;

    height:74px;

    font-size:2rem;

}

.badge{

    font-size:.65rem;

}

.app-header h1{

    font-size:2.4rem;

}

.app-header p{

    font-size:.95rem;

}

#userInput{

    min-height:220px;

    padding:18px;

}

.button-row{

    flex-direction:column;

}

.primary-btn,

.secondary-btn{

    width:100%;

}

.output-buttons{

    width:100%;

}

.icon-btn{

    flex:1;

}

.features-grid{

    grid-template-columns:1fr;

}

}



/* ===========================
   LARGE SCREENS
=========================== */

@media(min-width:1500px){

.container{

    max-width:1350px;

}

}



/* ===========================
   REDUCED MOTION
=========================== */

@media(prefers-reduced-motion:reduce){

*{

    animation:none !important;

    transition:none !important;

    scroll-behavior:auto;

}

}



/* ===========================
   GLASS BLUR SUPPORT
=========================== */

@supports(backdrop-filter:blur(20px)){

.input-card,

.analysis-card,

.feature-card{

    backdrop-filter:blur(22px);

}

}



/* ===========================
   HOVER SCALE
=========================== */

button{

    transition:

        transform .25s,

        background .25s,

        box-shadow .25s;

}

button:hover{

    transform:

        translateY(-2px);

}



/* ===========================
   FINISH
=========================== */

html{

    background:#06070c;

}

body{

    min-height:100vh;

}