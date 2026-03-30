using System;
using System.IO;
using System.Media;
using CybersecurityChatbot.UI;

namespace CybersecurityChatbot.ChatBot
{
    public static class VoiceGreeting
    {
        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        public static void Play()
        {
            try
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string wavPath = Path.Combine(basePath, "Assets", "greeting.wav");

                if (File.Exists(wavPath))
                {
                    SoundPlayer player = new SoundPlayer(wavPath);
                    player.PlaySync();
                }
                else
                {
                    ConsoleUI.WriteColour("  🔊 [Voice greeting file not found — skipping]", ConsoleColor.DarkYellow);
                }
            }
            catch (Exception ex)
            {
                ConsoleUI.WriteColour($"  ⚠️  Could not play voice greeting: {ex.Message}", ConsoleColor.DarkYellow);
            }
        }
    }
}