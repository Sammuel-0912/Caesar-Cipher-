using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "hello"; // Example message
            int key = 3; // Example key

            string encrypted = Encrypt(message, key);
            Console.WriteLine("Encrypted message: " + encrypted);
        }

        static string Encrypt(string message, int key)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] secretMessage = message.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int indexAlpha = Array.IndexOf(alphabet, letter);
                int position = (indexAlpha + key) % alphabet.Length;
                char encryptedLetter = alphabet[position];
                encryptedMessage[i] = encryptedLetter;
            }
            string secretword = new string(encryptedMessage);
            return secretword;
        }
    }
}

