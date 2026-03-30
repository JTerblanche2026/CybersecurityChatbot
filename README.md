# Cybersecurity Awareness Chatbot

A C# console application developed for PROG6221 - Programming 2A at The Independent Institute of Education.
This chatbot educates South African citizens on cybersecurity awareness topics in a conversational manner.



## Project Structure

CybersecurityChatbot/
├── .github/
│   └── workflows/
│       └── ci.yml          ← GitHub Actions CI
├── Assets/
│   └── greeting.wav        ← Voice greeting
├── ChatBot/
│   ├── ChatEngine.cs       ← Core response logic
│   ├── ResponseBank.cs     ← All predefined responses
│   └── VoiceGreeting.cs    ← Voice greeting handler
├── UI/
│   └── ConsoleUI.cs        ← Console formatting and display
├── Program.cs              ← Entry point
└── README.md
```

---

##  How to Run

### Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Windows OS (required for voice greeting)
- Visual Studio Code with C# extension

### Steps
1. Clone the repository:
```bash
   git clone https://github.com/YOUR-USERNAME/CybersecurityChatbot.git
   cd CybersecurityChatbot
```

2. Restore dependencies:
```bash
   dotnet restore
```

3. Build the project:
```bash
   dotnet build
```

4. Run the application:
```bash
   dotnet run
```

---

## Features

- **Voice Greeting** — Plays a recorded WAV greeting on startup
- **ASCII Art Logo** — Displays a cybersecurity themed logo
- **Personalised Interaction** — Remembers your name throughout the chat
- **Keyword Recognition** — Responds to cybersecurity topics including:
  - Passwords
  - Phishing
  - Scams
  - Privacy
  - Malware
  - VPNs
  - Two-factor authentication
- **Random Tips** — Provides varied tips on request
- **Conversation Flow** — Handles follow-up questions naturally
- **Input Validation** — Handles empty and unrecognised inputs gracefully

---

## Example Commands

| What you type | What the bot does |
|---------------|-------------------|
| `hi` | Friendly greeting |
| `what can i ask` | Lists available topics |
| `password tip` | Random password safety tip |
| `phishing tip` | Random phishing awareness tip |
| `browsing tip` | Random safe browsing tip |
| `tell me more` | Continues on the last topic |
| `tell me about phishing` | Explains phishing |
| `what is a vpn` | Explains VPNs |
| `bye` | Exits the chatbot |

---

## CI Workflow

This project uses GitHub Actions for Continuous Integration. The workflow:
- Triggers on every push and pull request to `main`
- Restores dependencies
- Builds the project in Release mode
- Confirms a successful build

### CI Screenshot
![CI Success](assets/ci-screenshot.png)



---

## References

Pieterse, H. 2021. The Cyber Threat Landscape in South Africa: A 10-Year Review.
The African Journal of Information and Communication, 28(28).
doi: https://doi.org/10.23962/10539/32213