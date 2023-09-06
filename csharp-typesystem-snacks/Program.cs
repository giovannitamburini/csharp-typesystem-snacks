﻿// See https://aka.ms/new-console-template for more information

/*

// Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.

Console.Write("Inserisci un numero intero: ");

// chiedo all'utente di inserire il primo numero
int firstNumber = int.Parse(Console.ReadLine());

// chiedo all'utente di inserire un secondo numero
Console.Write("Inserisci un secondo numero intero: ");

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

Console.WriteLine("------------------------");

// ------------------------------------------------------------

// Snack 2 : L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.

Console.Write("Inserisci una parola: ");

// chiedo all'utente di inserire una parola
string firstWord = Console.ReadLine();

Console.Write("Inserisci una seconda parola: ");

string secondWord = Console.ReadLine();

if (firstWord.Length > secondWord.Length)
{
    Console.WriteLine($"{firstWord}, {secondWord}");

} else if (firstWord.Length < secondWord.Length)
{
    Console.WriteLine($"{secondWord}, {firstWord}");

} else
{
    Console.WriteLine($"Hai inserito la stessa parola ({firstWord})");
}

Console.WriteLine("------------------------");

// ------------------------------------------------------------



// Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.

// inizializzo un array che conterrà 10 elementi
int[] userNumbers = new int[10];

// inizializzo una variabile int per la somma dei numeri inseiri dall'utente
int sumUserNumbers = 0;

// chiedo all'utente 10 volte di inseirire un numero
for(int i = 0; i < 10; i++)
{
    Console.Write($"inserisci il {i + 1}° numero intero casuale: ");

    userNumbers[i] = int.Parse(Console.ReadLine());

    // aggiungo alla sommatoria il valore dell'elemento ì dell'array userNumbers
    sumUserNumbers += userNumbers[i];
}

// stampo a video la somma dei numeri inseriti dall'utente
Console.WriteLine($"La somma dei numeri che hai inserito è uguale a {sumUserNumbers}");

Console.WriteLine("------------------------");

// ------------------------------------------------------------


// Snack 4: Calcola la somma e la media dei numeri da 2 a 10.

int[] numbersFrom2to10 = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int sumNumbersFrom2to10 = 0;

for (int i = 0; i < numbersFrom2to10.Length; i++)
{
    sumNumbersFrom2to10 += numbersFrom2to10[i];
}

Console.WriteLine($"la somma dei numeri da 2 a 10 è pari a {sumNumbersFrom2to10}");

float avarageNumbersFrom2to10 = (float)sumNumbersFrom2to10 / numbersFrom2to10.Length;

Console.WriteLine($"la media dei numeri da 2 a 10 è pari a: {avarageNumbersFrom2to10}");

Console.WriteLine("------------------------");

// ------------------------------------------------------------

*/
// Snack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

Console.Write("Inserisci un numero intero: ");

// chiedo all'utente di inserire un numero intero, e ne faccio la conversione in intero
int userNumberSnack5 = int.Parse(Console.ReadLine());

if(userNumberSnack5 % 2 == 0)
{
    // stampo a video il numero dell'utente visto che è pari
    Console.WriteLine($"{userNumberSnack5} è pari");

} else
{
    // stampo a video il numero dell'utente + 1 visto che è dispari
    Console.WriteLine($"{userNumberSnack5 + 1}, poichè il numero che hai inserito è dispari");
}