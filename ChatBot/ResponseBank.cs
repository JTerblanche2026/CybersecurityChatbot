using System;
using System.Collections.Generic;

namespace CybersecurityChatbot.ChatBot
{
    public static class ResponseBank
    {
        // ── Random response lists ────────────────────────────────────
        private static readonly Random _random = new Random();

        private static readonly List<string> _passwordTips = new List<string>
        {
            "Use at least 12 characters mixing uppercase, lowercase, numbers and symbols.",
            "Never reuse the same password across multiple accounts.",
            "Consider using a password manager like Bitwarden or LastPass.",
            "Avoid using personal info like birthdays or names in your passwords.",
            "Enable two-factor authentication wherever possible for extra security."
        };

        private static readonly List<string> _phishingTips = new List<string>
        {
            "Be cautious of emails asking for personal information — legitimate companies never do this.",
            "Always check the sender's email address carefully for slight misspellings.",
            "Hover over links before clicking to see where they actually lead.",
            "If an email creates urgency or panic, it's likely a phishing attempt.",
            "When in doubt, go directly to the website instead of clicking email links."
        };

        private static readonly List<string> _browsingTips = new List<string>
        {
            "Always look for HTTPS and a padlock icon before entering any personal info.",
            "Avoid using public Wi-Fi for banking or sensitive activities.",
            "Keep your browser and extensions updated to patch security vulnerabilities.",
            "Use a reputable ad blocker to reduce exposure to malicious ads.",
            "Clear your cookies and cache regularly to protect your browsing history."
        };

        private static readonly List<string> _privacyTips = new List<string>
        {
            "Review your social media privacy settings regularly.",
            "Be careful about what personal information you share online.",
            "Use a VPN when browsing on public networks.",
            "Regularly check which apps have access to your camera and microphone.",
            "Delete accounts and apps you no longer use to reduce your digital footprint."
        };

        // ── Keyword response dictionary ──────────────────────────────
        public static readonly Dictionary<string, string> KeywordResponses =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "password",   "Passwords are your first line of defence! Use strong, unique passwords for every account and never share them." },
            { "phishing",   "Phishing is when attackers disguise themselves as trusted sources to steal your info. Always verify before you click!" },
            { "scam",       "Scams are becoming more sophisticated in South Africa. If something feels too good to be true, it probably is." },
            { "privacy",    "Protecting your privacy online is crucial. Limit what you share and regularly review your account settings." },
            { "malware",    "Malware is malicious software designed to damage or gain unauthorised access to your device. Keep your antivirus updated!" },
            { "virus",      "Computer viruses can spread quickly. Never download software from untrusted sources and scan regularly." },
            { "vpn",        "A VPN encrypts your internet connection, keeping your data safe especially on public Wi-Fi networks." },
            { "2fa",        "Two-factor authentication adds an extra layer of security. Enable it on all your important accounts!" },
            { "firewall",   "A firewall monitors incoming and outgoing network traffic and blocks suspicious activity." },
            { "encryption", "Encryption converts your data into unreadable code so only authorised parties can access it." }
        };

        // ── General conversation responses ───────────────────────────
        public static readonly Dictionary<string, string> GeneralResponses =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "how are you",     "I'm running securely and feeling great! Ready to help you stay safe online. 😊" },
            { "what is your purpose", "I'm your Cybersecurity Awareness Assistant! I help South African citizens understand and avoid cyber threats." },
            { "what can i ask",  "You can ask me about passwords, phishing, scams, privacy, malware, VPNs, 2FA, firewalls, and much more!" },
            { "hello",           "Hello there! Great to see you taking cybersecurity seriously. How can I help you today?" },
            { "hi",              "Hi! I'm your cybersecurity guide. What would you like to learn about today?" },
            { "help",            "I can help you with: passwords, phishing, scams, safe browsing, privacy, malware, VPNs and more. Just ask!" },
            { "bye",             "Stay safe online! Remember to keep your passwords strong and never click suspicious links. Goodbye! 👋" },
            { "goodbye",         "Goodbye! Keep practising good cybersecurity habits every day. Stay safe! 👋" }
        };

        // ── Random tip getters ───────────────────────────────────────
        public static string GetRandomPasswordTip()   => _passwordTips[_random.Next(_passwordTips.Count)];
        public static string GetRandomPhishingTip()   => _phishingTips[_random.Next(_phishingTips.Count)];
        public static string GetRandomBrowsingTip()   => _browsingTips[_random.Next(_browsingTips.Count)];
        public static string GetRandomPrivacyTip()    => _privacyTips[_random.Next(_privacyTips.Count)];

        // ── Default / fallback response ──────────────────────────────
        public static string DefaultResponse =>
            "I didn't quite understand that. Could you rephrase? You can ask me about passwords, phishing, scams, or safe browsing.";
    }
}