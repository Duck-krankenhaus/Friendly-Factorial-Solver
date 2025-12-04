using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter text to encrypt: ");
        string input = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Bruuuuuuuuuuuuuuuuuuuuuuuh");
            return;
        }

        Console.Write("Enter shift (number): ");
        if (!int.TryParse(Console.ReadLine(), out int shift))
        {
            Console.WriteLine("Bruuuuuuuuuuuuuuuuuuuuuuuh");
            return;
        }

        string encrypted = EncryptCaesar(input, shift);
        Console.WriteLine($"\nEncrypted text: {encrypted}");
    }

    static string EncryptCaesar(string text, int shift)
    {
        char[] buffer = text.ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];

            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)(((letter + shift - offset) % 26 + 26) % 26 + offset);
            }

            buffer[i] = letter;
        }

        return new string(buffer);
    }
}
