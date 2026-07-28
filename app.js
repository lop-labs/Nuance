/* ==========================================================
   Nuance
   AI Critical Reading Assistant

   app.js
========================================================== */


/* ===========================
   ELEMENTS
=========================== */


const userInput = document.getElementById("userInput");

const analyzeBtn = document.getElementById("analyzeBtn");

const clearBtn = document.getElementById("clearBtn");

const exampleBtn = document.getElementById("exampleBtn");

const copyBtn = document.getElementById("copyBtn");

const exportBtn = document.getElementById("exportBtn");

const wordCounter = document.getElementById("wordCounter");

const aiOutput = document.getElementById("aiOutput");



/* ===========================
   GEMINI API KEY
=========================== */


const API_KEY = "YOUR_API_KEY_HERE";





/* ===========================
   WORD COUNTER
=========================== */


userInput.addEventListener(
    "input",
    () => {


        const words =
            userInput.value
            .trim()
            .split(/\s+/)
            .filter(Boolean);


        wordCounter.textContent =
            `${words.length} Words`;


    }
);






/* ===========================
   EXAMPLE TEXT
=========================== */


exampleBtn.addEventListener(
    "click",
    () => {


        userInput.value =
        `
        Social media platforms have changed how people consume news.
        While they allow faster information sharing, they also create
        challenges related to misinformation, political polarization,
        and algorithmic bias.
        `;


        userInput.dispatchEvent(
            new Event("input")
        );


    }
);






/* ===========================
   CLEAR BUTTON
=========================== */


clearBtn.addEventListener(
    "click",
    () => {


        userInput.value = "";

        wordCounter.textContent =
        "0 Words";


        aiOutput.innerHTML =
        `
        <div class="empty-icon">
            ✨
        </div>

        <h3>
            Ready to Analyze
        </h3>

        <p>
            Paste any article or speech above and let Nuance
            uncover hidden rhetoric, persuasive techniques,
            emotional framing, and potential bias.
        </p>
        `;


    }
);







/* ===========================
   ANALYSIS
=========================== */


analyzeBtn.addEventListener(
    "click",
    async () => {


        const text =
            userInput.value.trim();



        if(!text){


            alert(
                "Please enter text to analyze first."
            );


            return;

        }




        showLoading();



        analyzeBtn.disabled = true;




        try{


            const response =
            await fetch(

            `https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key=${API_KEY}`,

            {

                method:"POST",


                headers:{

                    "Content-Type":
                    "application/json"

                },


                body:JSON.stringify({

                    contents:[

                        {

                            parts:[

                                {

text:

`
You are Nuance, an AI critical reading assistant.

Analyze the following text.

Provide a structured response using:

<h3>Core Summary</h3>
Explain the main argument briefly.

<h3>Rhetorical Strategies</h3>
Identify:
- Emotional appeals
- Logical reasoning
- Persuasive techniques

<h3>Underlying Bias or Subtext</h3>
Identify:
- Assumptions
- Possible bias
- Framing techniques

<h3>Critical Reflection</h3>
Give a short evaluation of the argument.

Text:

${text}

`

                                }

                            ]

                        }

                    ]

                })

            });


            const data =
            await response.json();



            if(
                !data.candidates ||
                !data.candidates[0]
            ){

                throw new Error(
                    "Invalid AI response"
                );

            }




            let result =

            data
            .candidates[0]
            .content
            .parts[0]
            .text;



            displayResult(result);



        }


        catch(error){


            console.error(error);



            aiOutput.innerHTML =

            `
            <div class="empty-state">

            <div class="empty-icon">
            ⚠️
            </div>


            <h3>
            Something went wrong
            </h3>


            <p>
            Check your API key or connection
            and try again.
            </p>


            </div>
            `;


        }



        finally{


            analyzeBtn.disabled =
            false;


        }


    }

);







/* ===========================
   DISPLAY RESULT
=========================== */


function displayResult(text){


    aiOutput.className =
    "output";


    aiOutput.innerHTML =

    text
    .replace(
        /\*\*(.*?)\*\*/g,
        "<strong>$1</strong>"
    )
    .replace(
        /\n/g,
        "<br>"
    );


}







/* ===========================
   LOADING
=========================== */


function showLoading(){


    aiOutput.innerHTML =


    `
    <div class="loading">


        <div class="spinner"></div>


        <p>
        Analyzing rhetoric, bias, and hidden meaning...
        </p>


    </div>
    `;


}







/* ===========================
   COPY OUTPUT
=========================== */


copyBtn.addEventListener(

"click",

async()=>{


    const text =
    aiOutput.innerText;



    await navigator.clipboard.writeText(
        text
    );



    copyBtn.textContent =
    "✓ Copied";



    setTimeout(()=>{

        copyBtn.textContent =
        "📋 Copy";

    },2000);



}

);








/* ===========================
   EXPORT TXT
=========================== */


exportBtn.addEventListener(

"click",

()=>{


    const content =
    aiOutput.innerText;



    const file =
    new Blob(

        [content],

        {
            type:"text/plain"
        }

    );



    const link =
    document.createElement("a");



    link.href =
    URL.createObjectURL(file);



    link.download =
    "Nuance_Analysis.txt";



    link.click();



}

);