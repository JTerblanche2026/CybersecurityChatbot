using CybersecurityChatbot.UI;
using CybersecurityChatbot.ChatBot;

namespace CybersecurityChatbot
{
    class Program
    {
        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        static void Main(string[] args)
        {
            // ── Display ASCII logo ───────────────────────────────────
            ConsoleUI.PrintLogo();

            // ── Play voice greeting ──────────────────────────────────
            VoiceGreeting.Play();

            // ── Start chatbot ────────────────────────────────────────
            ChatEngine chatEngine = new ChatEngine();
            chatEngine.StartChat();
            chatEngine.RunLoop();
        }
    }
}
