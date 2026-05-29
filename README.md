# PROG6221-part2
GUI application
TechnoGeek AI - Cybersecurity Awareness Chatbot
Project: TechnoGeek AI - Cybersecurity Awareness Chatbot

Project Overview
TechnoGeek AI is a Cybersecurity Awareness Chatbot built using C# and WPF (Windows Presentation Foundation). The chatbot educates users on cybersecurity topics such as phishing, passwords, malware, VPNs, firewalls, and more. Part 2 builds directly on top of Part 1 by introducing a full Graphical User Interface, memory, sentiment detection, conversation flow, and a more intelligent response system.

TechnoGeek AI, How the App Works

Step 1,how to Launch the App
When you run the app the Home Page appears first.
You will see the TechnoGeek logo, a welcome message, and a GET STARTED button.
Click the button to move to the next page.

Step 2,  Enter Your Name
The Username Page appears.
Type your name into the input box and click SUBMIT.

If you leave the name empty a message will appear telling you to enter your name.
If you type numbers or symbols a message will appear telling you to use letters only.
If your name is valid and you have never used the app before the bot will say "Welcome".
If your name is valid and you have used the app before the bot will say "Welcome back".

Your name is saved to a file called user_names.txt so the app remembers you next time.
As soon as you submit your name the voice greeting plays automatically.

Step 3, Chat with TechnoGeek AI
The Chat Page appears with the bot greeting you by name.
Type your question in the input box at the bottom and click SEND.
Your message appears in the chat in pink and the bot reply appears in green.

What You Can Ask
You can ask the bot about any of these cybersecurity topics:
TopicExample QuestionPassword safety"How do I create a strong password?"Phishing"What is phishing?"Malware"Tell me about malware"VPN"Why should I use a VPN?"Firewall"What does a firewall do?"2FA"What is two factor authentication?"Scams"How do I avoid scams?"Privacy"How do I protect my privacy?"Hacked accounts"My account was hacked"Fraud"I think I have been a victim of fraud"Social engineering"What is social engineering?"Cybersecurity general"What is cybersecurity?"

Special Features
Follow Up Questions
After the bot answers you can ask for more information without repeating yourself.
Just type any of these phrases:

"tell me more"
"more tips"
"what else"
"explain more"

The bot will give you another answer on the same topic.

Memory and Interests
You can tell the bot what you are interested in and it will remember it.
Example:

You: "I am interested in password safety"
Bot: "Great, I will remember that you are interested in password safety"

Every 3 messages the bot will automatically remind you of your interests and share related tips.
You can also ask the bot what it remembers about you:

You: "what do you remember"
Bot: "I remember your name is Zenande. I also remember you are interested in password safety."


Sentiment Detection
The bot can detect how you are feeling from your message and respond with empathy.
Example:

You: "I am worried about online scams"
Bot: "It is completely understandable to feel worried. Scammers can be very convincing. Let me share some tips to help you stay safe..."

Emotions the bot can detect:

Worried
Scared
Frustrated
Confused
Happy
Sad
Angry


Ending the Session

Improvements

What Improved from Part 1 to Part 2 Part 1 - Console Application Part 1 was a basic console-based chatbot that ran entirely in the terminal. It had the following features:
Text-based interface using Console.WriteLine and Console.ReadLine ASCII art logo displayed in the terminal Typing effect using Thread.Sleep to simulate the bot typing Voice greeting using SoundPlayer to play a WAV file on startup Keyword matching using parallel string arrays with a for loop and Contains() A username captured at the start and used throughout the session Basic cybersecurity topics: password, phishing, browsing, malware, 2FA, VPN, social engineering Exit command to end the session Default fallback response for unrecognised input Fixed a substring collision bug where "phishing" incorrectly matched "hi" using Regex.IsMatch with word boundary anchors
Part 2 - WPF GUI Application Part 2 completely upgrades the chatbot from a console app to a fully designed graphical application. Here is every improvement made:
1.	Graphical User Interface
Built using WPF with three separate pages managed by Grid visibility switching Home Page - displays the logo, welcome message, and a Start button Username Page - prompts the user to enter their name with validation Chat Page - full chat interface with a ListView for messages, a TextBox for input, and a Send button Rounded corners on all buttons and input fields using Border with CornerRadius Dark navy colour theme with cyan accents throughout Logo image displayed on the home and username pages Header bar on the chat page showing the bot name and logo
2.	Keyword Recognition Upgrade
Moved from parallel string arrays to ArrayList for both replies and ignore words Answers stored in the format "keyword response text" inside the reply ArrayList Per-word matching logic iterates through each word in the user input, skips ignored words, searches the reply ArrayList for matches, and randomly selects one answer per matched word Covers more cybersecurity keywords: password, phishing, scam, privacy, malware, vpn, 2fa, firewall, browsing, cybersecurity, social engineering, hacked, fraud Each keyword has 3 different response options for variety
3.	Random Responses
For each matched keyword the bot randomly selects one of three possible answers using Random.Next() Responses stored in ArrayLists making it easy to add more in future Keeps conversations varied and more engaging for the user
4.	Conversation Flow
Follow-up phrases detected: "tell me more", "more tips", "what else", "explain more" The bot tracks the last topic discussed using a last_topic variable When a follow-up phrase is detected the bot pulls another answer on the same topic without the user needing to repeat themselves Seamless conversation without restarting each time
5.	Memory and Recall
The bot remembers the username across the session Returning users are greeted with "Welcome back" using a text file (user_names.txt) to store known usernames User interests stored in a separate file (interested_topic.txt) when the user says "I am interested in..." Every 3 messages the bot automatically reminds the user of their stored interests and provides relevant tips User can ask "what do you remember" to get a full recall of stored details
6.	Sentiment Detection
The bot detects emotional keywords in user input: worried, scared, frustrated, confused, happy, sad, angry Responds empathetically before providing information For negative sentiments the bot automatically shares a relevant cybersecurity tip without making the user ask again Sentiment responses stored in the reply ArrayList using the same keyword format
7.	Error Handling and Edge Cases
Empty input is caught and handled with a friendly message Name validation checks for empty input and letters-only before allowing the user to proceed Unrecognised input returns a random fallback message from a set of 5 options Special characters removed from user input before processing using RemoveSpecialCharacters() The app never crashes on unexpected input
8.	Code Optimisation and OOP
Separated into multiple classes: MainWindow, respond, user_name, voice_greeting respond class handles all ArrayList loading (replies and ignore words) user_name class handles name validation, file reading, and welcome messages voice_greeting class handles WAV file playback error_method creates styled chat bubbles with colour-coded backgrounds for bot vs user messages Code is ready for further expansion in Part 3
9.	Voice Greeting
Voice plays when the user starts the program instead of on app startup Uses MediaPlayer from System.Windows.Media for compatibility with .NET 6 WAV file path resolved using Assembly.GetExecutingAssembly().Location for reliability
10.	Visual Chat Bubbles
Bot messages displayed with a green background, dark blue name, and black message text User messages displayed with a deep pink background, purple name, and white message text Each message wrapped in a Border with rounded CornerRadius for a modern chat look Auto-scroll to the latest message after every send


Type exit at any time to end the chat session.

Bot: "Goodbye! Stay safe online - think before you click!"
