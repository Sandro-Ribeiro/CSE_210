// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Garante um valor padrão mesmo que null seja retornado
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine() ?? "Unknown";

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine() ?? "Unknown";

        // Exibe a mensagem formatada
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}


