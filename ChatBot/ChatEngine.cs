using System;
using System.Collections.Generic;
using CybersecurityChatbot.UI;

namespace CybersecurityChatbot.ChatBot
{
    public class ChatEngine
    {
        // User memory 
        private string _userName = "Friend";
        private string _lastTopic = "";

        // Main response handler 
        public string GetResponse(string input)
{
    // Handle empty or whitespace input
    if (string.IsNullOrWhiteSpace(input))
        return "It looks like you didn't type anything. Please try asking me a question!";

    string lowered = input.ToLower().Trim();

    // Check for exit command 
    if (lowered == "bye" || lowered == "goodbye" || lowered == "exit" || lowered == "quit")
        return ResponseBank.GeneralResponses["bye"];

    // Check for random tip requests first 
    if (lowered.Contains("password tip") || lowered.Contains("password advice"))
    {
        _lastTopic = "password";
        return ResponseBank.GetRandomPasswordTip();
    }

    if (lowered.Contains("phishing tip") || lowered.Contains("phishing advice"))
    {
        _lastTopic = "phishing";
        return ResponseBank.GetRandomPhishingTip();
    }

    if (lowered.Contains("browsing tip") || lowered.Contains("browsing advice"))
    {
        _lastTopic = "browsing";
        return ResponseBank.GetRandomBrowsingTip();
    }

    if (lowered.Contains("privacy tip") || lowered.Contains("privacy advice"))
    {
        _lastTopic = "privacy";
        return ResponseBank.GetRandomPrivacyTip();
    }

    // Check keyword responses before general 
    foreach (var entry in ResponseBank.KeywordResponses)
    {
        if (lowered.Contains(entry.Key.ToLower()))
        {
            _lastTopic = entry.Key.ToLower();
            return entry.Value;
        }
    }

    // Handle follow-up requests 
    if (lowered.Contains("another") || lowered.Contains("more") ||
        lowered.Contains("tell me more") || lowered.Contains("explain more"))
    {
        return HandleFollowUp();
    }

    // Check general conversation last 
    foreach (var entry in ResponseBank.GeneralResponses)
    {
        if (lowered.Contains(entry.Key))
            return entry.Value;
    }

    // Default fallback 
    return ResponseBank.DefaultResponse;
}

        // Follow-up handler 
        private string HandleFollowUp()
        {
            switch (_lastTopic)
            {
                case "password":
                    return ResponseBank.GetRandomPasswordTip();
                case "phishing":
                    return ResponseBank.GetRandomPhishingTip();
                case "browsing":
                    return ResponseBank.GetRandomBrowsingTip();
                case "privacy":
                    return ResponseBank.GetRandomPrivacyTip();
                default:
                    return "What topic would you like to explore more? Try asking about passwords, phishing, browsing, or privacy!";
            }
        }

        // Greeting handler 
        public void StartChat()
        {
            ConsoleUI.PrintDivider();
            ConsoleUI.BotMessage("Hello! Welcome to the Cybersecurity Awareness Bot.");
            ConsoleUI.BotMessage("Before we begin, what is your name?");
            ConsoleUI.UserPrompt();

            string name = Console.ReadLine() ?? "";

            // Validate name input
            while (string.IsNullOrWhiteSpace(name))
            {
                ConsoleUI.BotMessage("I didn't catch that. Could you please enter your name?");
                ConsoleUI.UserPrompt();
                name = Console.ReadLine() ?? "";
            }

            _userName = name.Trim();

            ConsoleUI.BotMessage($"It's good to meet you, {_userName}! ");
            ConsoleUI.BotMessage($"I'm here to help you stay safe online.");
            ConsoleUI.BotMessage("You can ask me about passwords, phishing, scams, safe browsing, and more!");
            ConsoleUI.BotMessage("Type 'bye' at any time to exit.");
            ConsoleUI.PrintDivider();
        }

        // Main chat loop
        public void RunLoop()
        {
            string input = "";

            while (true)
            {
                ConsoleUI.UserPrompt();
                input = Console.ReadLine() ?? "";

                string response = GetResponse(input ?? "");
                ConsoleUI.BotMessage(response);

                // Exit condition
                if (!string.IsNullOrWhiteSpace(input) &&
                    (input.ToLower().Contains("bye") ||
                     input.ToLower().Contains("goodbye") ||
                     input.ToLower() == "exit" ||
                     input.ToLower() == "quit"))
                {
                    break;
                }
            }
        }

        // Getter for username 
        public string GetUserName() => _userName;
    }
}