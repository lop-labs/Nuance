
// =========================
// Nuance - app.js
// =========================

// ---------- Elements ----------

const userInput = document.getElementById("userInput");
const analyzeBtn = document.getElementById("analyzeBtn");
const clearBtn = document.getElementById("clearBtn");
const exampleBtn = document.getElementById("exampleBtn");

const aiOutput = document.getElementById("aiOutput");
const loadingState = document.getElementById("loadingState");
const emptyState = document.getElementById("emptyState");

const copyBtn = document.getElementById("copyBtn");
const downloadBtn = document.getElementById("downloadBtn");

const wordCounter = document.getElementById("wordCounter");

// ======================================
// Gemini API
// ======================================

const API_KEY = "YOUR_API_KEY_HERE";

const API_URL =
`https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key=${API_KEY}`;

// ======================================
// Example Text
// ======================================

const exampleText = `Artificial intelligence will fundamentally reshape education.

Supporters argue that AI tutors can personalize learning, improve accessibility, and reduce educational inequality.

Critics, however, warn that AI could replace human interaction, encourage dependency, and reinforce existing biases if not carefully regulated.`;

// ======================================
// Prompt
// ======================================

function buildPrompt(text){

return `You are Nuance, an AI specialized in media literacy and critical reading.

Analyze the following text.

Return ONLY HTML.

Use this structure:

<h2>📌 Core Summary</h2>

<p>Two concise sentences.</p>

<h2>🎭 Rhetorical Strategies</h2>

<ul>
<li>...</li>
<li>...</li>
<li>...</li>
</ul>

<h2>⚖ Bias & Subtext</h2>

<ul>
<li>...</li>
<li>...</li>
<li>...</li>
</ul>

<h2>🧠 Confidence</h2>

<p>High / Medium / Low</p>

Text:

${text}`;

}

// ======================================
// Helpers
// ======================================

function showLoading(){

loadingState.classList.remove("hidden");
emptyState.classList.add("hidden");
aiOutput.classList.add("hidden");

analyzeBtn.disabled = true;
analyzeBtn.textContent = "Analyzing...";

}

function hideLoading(){

loadingState.classList.add("hidden");

analyzeBtn.disabled = false;
analyzeBtn.textContent = "Analyze Subtext";

}

function showOutput(html){

emptyState.classList.add("hidden");

loadingState.classList.add("hidden");

aiOutput.classList.remove("hidden");

aiOutput.innerHTML = html;

}

function showError(message){

showOutput(`<p style="color:#ff6b6b;">❌ ${message}</p>`);

}

function updateWordCounter(){

const words =
userInput.value
.trim()
.split(/\s+/)
.filter(Boolean)
.length;

wordCounter.textContent =
`${words} Word${words===1?"":"s"}`;

}

function autoResize(){

userInput.style.height="auto";

userInput.style.height=
userInput.scrollHeight+"px";

}

// ======================================
// Analyze
// ======================================

async function analyzeText(){

const text=userInput.value.trim();

if(!text){

alert("Paste some text first.");

return;

}

showLoading();

try{

const response=await fetch(API_URL,{

method:"POST",

headers:{
"Content-Type":"application/json"
},

body:JSON.stringify({

contents:[

{

parts:[

{

text:buildPrompt(text)

}

]

}

]

})

});

if(!response.ok){

throw new Error(
`Request failed (${response.status})`
);

}

const data=await response.json();

const output=
data?.candidates?.[0]?.content?.parts?.[0]?.text;

if(!output){

throw new Error(
"No response received from Gemini."
);

}

showOutput(output);

}

catch(error){

console.error(error);

showError(error.message);

}

finally{

hideLoading();

}

}

// ======================================
// Buttons
// ======================================

analyzeBtn.addEventListener(
"click",
analyzeText
);

// ---------- Clear ----------

clearBtn.addEventListener("click",()=>{

userInput.value="";

aiOutput.innerHTML="";

emptyState.classList.remove("hidden");

aiOutput.classList.add("hidden");

updateWordCounter();

autoResize();

});

// ---------- Example ----------

exampleBtn.addEventListener("click",()=>{

userInput.value=exampleText;

updateWordCounter();

autoResize();

});

// ---------- Copy ----------

copyBtn.addEventListener("click",async()=>{

const text=aiOutput.innerText;

if(!text)return;

try{

await navigator.clipboard.writeText(text);

copyBtn.textContent="✅ Copied";

setTimeout(()=>{

copyBtn.textContent="📋 Copy";

},2000);

}

catch{

alert("Couldn't copy.");

}

});

// ---------- Download ----------

downloadBtn.addEventListener("click",()=>{

const text=aiOutput.innerText;

if(!text)return;

const blob=new Blob(
[text],
{type:"text/plain"}
);

const url=
URL.createObjectURL(blob);

const a=document.createElement("a");

a.href=url;

a.download="Nuance Analysis.txt";

a.click();

URL.revokeObjectURL(url);

});

// ======================================
// Keyboard Shortcuts
// ======================================

userInput.addEventListener(
"keydown",
e=>{

if(e.ctrlKey && e.key==="Enter"){

analyzeText();

}

}
);

// ======================================
// Input Events
// ======================================

userInput.addEventListener("input",()=>{

updateWordCounter();

autoResize();

});

// ======================================
// Startup
// ======================================

updateWordCounter();

autoResize();