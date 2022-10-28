// See https://aka.ms/new-console-template for more information
using System;

int[] arrayToPrint = { 1, 2, 3, 4, 5, 6 };

StampaArray(arrayToPrint);
    
void StampaArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)   
            Console.Write(array[i]);
        else
            Console.Write(array[i] + ",");

    }
    Console.Write(" ]");
}

Console.WriteLine();
Console.WriteLine("inserisci un numero");
int userValue = Convert.ToInt32(Console.ReadLine());

int result = Quadrato(userValue);

int Quadrato(int value)
{
    return value * value;
}

Console.WriteLine(result + " è il suo quadrato");

   
int[] print = ElevaArrayAlQuadrato(arrayToPrint);

int[] ElevaArrayAlQuadrato(int[] array)
{ 
    int[] arrayToPrint = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {

        arrayToPrint[i] = Quadrato(array[i]);
    }

    return arrayToPrint;
}

StampaArray(print);
Console.WriteLine();
 
int totalArraySum = SommaElementiArray(arrayToPrint);

int SommaElementiArray(int[] array){

    int total = 0;

    for (int i = 0; i < array.Length; i++)
    {
        total += array[i];
    }

    return total;
}

Console.WriteLine(totalArraySum);

int[] numeri = { 2, 6, 7, 5, 3, 9 };

AllFunction(numeri);
bool loop = true;

while (loop)
{
    Console.WriteLine("continuare scrivi yes o no");
    string continueTest = Console.ReadLine().ToLower();

    if(continueTest == "no")
    {
        loop = false;
        break;
    } 
    else
    {

        Console.WriteLine("Scrivi la lunghezza di un array");
        int ArrayLength = Convert.ToInt32(Console.ReadLine());
        int[] ArrayToPopolate = new int[ArrayLength];

        for (int i = 0; i < ArrayToPopolate.Length; i++)
        {
            Console.WriteLine("scrivi un valore da inserire");
            ArrayToPopolate[i] = Convert.ToInt32(Console.ReadLine());
        }

        AllFunction(ArrayToPopolate);

    }
}

void AllFunction(int[] numeri)
{
    StampaArray(numeri);
    Console.WriteLine();
    int[] printNumeriArray = ElevaArrayAlQuadrato(numeri);
    StampaArray(printNumeriArray);
    Console.WriteLine();
    int totalNumeriSum = SommaElementiArray(numeri);
    Console.WriteLine(totalNumeriSum);
    int totalNumeriSumElevate = SommaElementiArray(printNumeriArray);
    Console.WriteLine(totalNumeriSumElevate);
}