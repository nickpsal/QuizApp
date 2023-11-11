# QuizApp<br>
# QuizAPP using .net 7 and WPF (c) 2023 - 2024.<br>
Tnis App it reads the questions and the Answers from a JSOM file shuufle them and the game is starting by puting the first question on screen. You can use multiple JSON files. When the game starts it allows you to choose witch JSON file you want to load.<br>
<br>
#JSON format<br>
[<br>
    {<br>
        "question": "Ποια απο αυτές ΔΕΝ είναι γλώσσες προγραμματισμού?",<br>
        "answers": [<br>
            {<br>
                "correct": true,<br>
                "text": "HTML"<br>
            },<br>
            {<br>
                "correct": false,<br>
                "text": "PHP"<br>
            },<br>
            {<br>
                "correct": false,<br>
                "text": "JAVASCRIPT"<br>
            },<br>
            {<br>
                "correct": false,<br>
                "text": "RUBY"<br>
            }<br>
        ]<br>
    },<br>
    {<br>
        "question": "Ποια απο αυτές ΔΕΝ είναι HTML tags?",<br>
        "answers": [<br>
            {<br>
                "correct": false,<br>
                "text": "HTML"<br>
            },<br>
            {<br>
                "correct": false,<br>
                "text": "BODY"<br>
            },<br>
            {<br>
                "correct": false,
                "text": "DIV"
            },
            {
                "correct": true,
                "text": "SPAM"
            }
        ]
    },
    {
        "question": "Πώς βρισκουμε το μέγεθος μιας λίστας?",
        "answers": [
            {
                "correct": false,
                "text": "size"
            },
            {
                "correct": false,
                "text": "indexOf"
            },
            {
                "correct": false,
                "text": "val()"
            },
            {
                "correct": true,
                "text": "length"
            }
        ]
    },
	{
        "question": "Πόιά χρονιά ιδρύθηκε η APPLE?",
        "answers": [
            {
                "correct": true,
                "text": "1976"
            },
            {
                "correct": false,
                "text": "1970"
            },
            {
                "correct": false,
                "text": "1968"
            },
            {
                "correct": false,
                "text": "1980"
            }
        ]
    },
	{
        "question": "Ποιος χαρακτήρας ΔΕΝ υπήρχε στην ταινία Pirates of Silicon Valley",
        "answers": [
            {
                "correct": false,
                "text": "Steve Jobs"
            },
            {
                "correct": false,
                "text": "Bill Gates"
            },
            {
                "correct": true,
                "text": "Wilcox"
            },
            {
                "correct": false,
                "text": "Paul Allen"
            }
        ]
    }
]

This Game was created by NIkolaos Psaltakis for Personal Use.
