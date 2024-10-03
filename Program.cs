//Desafio finalizado no dia 03/10/2024 - Cleyton Gravito
using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Testando a classe Nokia
        Console.WriteLine("Testando Nokia:");
        Smartphone nokia = new Nokia("123456789", "Nokia 3310", "111111111111", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
        Console.WriteLine();

        // Testando a classe Iphone
        Console.WriteLine("Testando iPhone:");
        Smartphone iphone = new Iphone("987654321", "iPhone 13", "222222222222", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
