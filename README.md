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
                "correct": false,<br>
                "text": "DIV"<br>
            },<br>
            {<br>
                "correct": true,<br>
                "text": "SPAM"<br>
            }<br>
        ]<br>
    },<br>
    {<br>
        "question": "Πώς βρισκουμε το μέγεθος μιας λίστας?",<br>
        "answers": [<br>
            {<br>
                "correct": false,<br>
                "text": "size"<br>
            },<br>
            {<br>
                "correct": false,<br>
                "text": "indexOf"<br>
            },<br>
            {<br>
                "correct": false,<br>
                "text": "val()"<br>
            },<br>
            {<br>
                "correct": true,<br>
                "text": "length"<br>
            }<br>
        ]<br>
    },<br>
	{<br>
        "question": "Πόιά χρονιά ιδρύθηκε η APPLE?",<br>
        "answers": [<br>
            {<br>
                "correct": true,<br>
                "text": "1976"<br>
            },<br>
            {<br>
                "correct": false,<br>
                "text": "1970"<br>
            },<br>
            {<br>
                "correct": false,<br>
                "text": "1968"<br>
            },<br>
            {<br>
                "correct": false,<br>
                "text": "1980"<br>
            }<br>
        ]<br>
    },<br>
	{<br>
        "question": "Ποιος χαρακτήρας ΔΕΝ υπήρχε στην ταινία Pirates of Silicon Valley",<br>
        "answers": [<br>
            {<br>
                "correct": false,<br>
                "text": "Steve Jobs"<br>
            },<br>
            {<br>
                "correct": false,<br>
                "text": "Bill Gates"<br>
            },<br>
            {<br>
                "correct": true,<br>
                "text": "Wilcox"<br>
            },<br>
            {<br>
                "correct": false,<br>
                "text": "Paul Allen"<br>
            }<br>
        ]<br>
    }<br>
]<br>
<br>
This Game was created by NIkolaos Psaltakis for Personal Use using C# and WPF.<br>
