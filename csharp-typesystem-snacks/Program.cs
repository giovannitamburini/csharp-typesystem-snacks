// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.

// chiedo all'utente di inserire il primo numero
Console.Write("Inserisci un numero: ");

int firstNumber = int.Parse(Console.ReadLine());

// chiedo all'utente di inserire un secondo numero
Console.Write("Inserisci un secondo numero: ");

int secondNumber = int.Parse(Console.ReadLine());

if(firstNumber > secondNumber)
{
    Console.WriteLine($"il primo numero ({firstNumber}) è il maggiore");

} else if(firstNumber < secondNumber)
{
    Console.WriteLine($"il secondo numero ({secondNumber}) è il maggiore");

} else
{
    Console.WriteLine("hai inserito due numeri uguali");
}