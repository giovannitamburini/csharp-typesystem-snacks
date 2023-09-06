// See https://aka.ms/new-console-template for more information

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

Console.WriteLine("------------------------");

// ------------------------------------------------------------


// Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

// array degli invitati
string[] partyGuests = {"Giulia", "Giovanni", "Giorgio", "Danilo", "Enrico", "Federico" };

Console.Write("Qual'è il tuo nome? ");

// chiedo il nome alla persona da controllare se presente nell'array degli invitati
string person = Console.ReadLine();

// controllo se il nome scritto dall'utente è contenuto nell'array
if (partyGuests.Contains(person))
{
    Console.WriteLine($"Prego {person}, puoi entrare");

} else
{
    Console.WriteLine($"Mi dispiace {person} ma il tuo nome non è nella lista e quindi non puoi entrare");
}

Console.WriteLine("------------------------");

// ------------------------------------------------------------


// Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

// creo un array vuoto
int[] emptyArray = new int[6];

// ciclo 6 volte, tante volte quante sono quelle a cui devo chiedere un numero all'utente
for (int i = 0; i < 6; i++)
{
    // chiedo all'utente di inserire un numero
    Console.Write($"Inserisci un {i + 1}° numero: ");
    int userNumberSnack7 = int.Parse(Console.ReadLine());

    // controllo se il numero è dispari
    if (userNumberSnack7 % 2 != 0)
    {
        // inserisco il numero dispari all'interno dell'array
        emptyArray[i] = userNumberSnack7;
    }
}

Console.WriteLine("------------------------");

// ------------------------------------------------------------

// Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

// creo un array di numeri interi
int[] integerNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// inizializzo una variabile int per la somma dei numeri in posizione dispari all'interno dell'array
int sumElementsInOddPosition = 0;

// ciclo i volte, dove i è uguale alla lunghezza del mio array di numeri interi
for (int i = 0; i < integerNumbers.Length; i++)
{
    // controllo se il numero è in posizione dispari all'interno dell'array
    if (i % 2 != 0)
    {
        // aggiungo alla somma totale il valore dell'elemento in posizione dispari
        sumElementsInOddPosition += integerNumbers[i];
    }
}

// stampo a video il valore della somma di tutti gli elementi in posizione dispari
Console.WriteLine($"La somma di tutti gli elementi che sono in posizione dispari all'interno dell'array è: {sumElementsInOddPosition}");

Console.WriteLine("------------------------");

// ------------------------------------------------------------

*/
// Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.

// inizializzo un array vuoto di 49 elementi
float[] emptyArraySnack9 = new float[49];

// ciclo finchè i è inferiori alla lunghezza del mio array
for (int i = 0; i < emptyArraySnack9.Length; i++)
{
    Console.Write("Inserisci un numero: ");

    // salvo in una variabile float il numero inserito dall'utente, dopo averlo convertito in un float
    float newUserNumber = float.Parse(Console.ReadLine());

    // sostituisco l'elemento nell'array in posizione i, con il numero inserito dall'utente
    emptyArraySnack9[i] = newUserNumber;
}