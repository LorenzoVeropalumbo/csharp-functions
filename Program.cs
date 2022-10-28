// See https://aka.ms/new-console-template for more information
using System;

//crezione dell'array
//int[] arrayToPrint = { 1, 2, 3, 4, 5, 6 };
//StampaArray(arrayToPrint);
//Console.WriteLine();
//Console.WriteLine("inserisci un numero");
//int userValue = Convert.ToInt32(Console.ReadLine());
//int result = Quadrato(userValue);
//Console.WriteLine(result + " è il suo quadrato");
//int[] print = ElevaArrayAlQuadrato(arrayToPrint);
//StampaArray(print);
//Console.WriteLine();
//int totalArraySum = SommaElementiArray(arrayToPrint);
//Console.WriteLine(totalArraySum);
//int[] numeri = { 2, 6, 7, 5, 3, 9 };
//AllFunction(numeri);
//bool loop = true;

//while (loop)
//{
//    Console.WriteLine("continuare scrivi yes o no");
//    string continueTest = Console.ReadLine().ToLower();

//    if(continueTest == "no")
//    {
//        loop = false;
//        break;
//    } 
//    else
//    {

//        Console.WriteLine("Scrivi la lunghezza di un array");
//        int ArrayLength = Convert.ToInt32(Console.ReadLine());
//        int[] ArrayToPopolate = new int[ArrayLength];

//        for (int i = 0; i < ArrayToPopolate.Length; i++)
//        {
//            Console.WriteLine("scrivi un valore da inserire");
//            ArrayToPopolate[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        AllFunction(ArrayToPopolate);

//    }
//}

//void AllFunction(int[] numeri)
//{
//    StampaArray(numeri);
//    Console.WriteLine();
//    int[] printNumeriArray = ElevaArrayAlQuadrato(numeri);
//    StampaArray(printNumeriArray);
//    Console.WriteLine();
//    int totalNumeriSum = SommaElementiArray(numeri);
//    Console.WriteLine(totalNumeriSum);
//    int totalNumeriSumElevate = SommaElementiArray(printNumeriArray);
//    Console.WriteLine(totalNumeriSumElevate);
//}

//int SommaElementiArray(int[] array){

//    int total = 0;

//    for (int i = 0; i < array.Length; i++)
//    {
//        total += array[i];
//    }

//    return total;
//}

//int[] ElevaArrayAlQuadrato(int[] array)
//{ 
//    int[] arrayToPrint = new int[array.Length];

//    for (int i = 0; i < array.Length; i++)
//    {

//        arrayToPrint[i] = Quadrato(array[i]);
//    }

//    return arrayToPrint;
//}

//int Quadrato(int value)
//{
//    return value * value;
//}

//void StampaArray(int[] array)
//{
//    Console.Write("[ ");
//    for (int i = 0; i < array.Length; i++)
//    {
//        if(i == array.Length - 1)   
//            Console.Write(array[i]);
//        else
//            Console.Write(array[i] + ",");

//    }
//    Console.Write(" ]");
//}

Console.WriteLine("Inserisci un numero");
int userNumberSelected = Convert.ToInt32(Console.ReadLine());
int result = userNumberSelected;
int index = 1;
int resultRicorsive = SommaElementiRicorsivo(userNumberSelected, index, result);

int SommaElementiRicorsivo(int userNumberSelected,int index,int result)
{
    if (result == 0)
    {
        return 1;
    } 
    else
    {
        if(result - 1 > index)
        {
            userNumberSelected += userNumberSelected * index;
            index++;
            return SommaElementiRicorsivo(userNumberSelected, index, result);
        } 
        else
        {
            return userNumberSelected;
        }
    }

}
Console.WriteLine("il risultato ricorsivo è " + resultRicorsive);



Console.WriteLine("Inserisci un numero");
int userNumberSelected1 = Convert.ToInt32(Console.ReadLine());
int result1 = 0;
int result2 = 1;
int result3 = 1;
int index1 = 1;
int result4 = SommaElementiFibonacci(userNumberSelected1, index1, result1, result2, result3);

int SommaElementiFibonacci(int userNumberSelected1, int index1, int result1, int result2, int result3)
{
    if (index1 < userNumberSelected1)
    {
        result3 = result1 + result2;
        result1 = result2;
        result2 = result3;
        index1++;
        return SommaElementiFibonacci(userNumberSelected1, index1, result1, result2, result3);
    } 
    else
    {
        return result3;
    }
}

Console.WriteLine("il risultato ricorsivo è " + result4);


{
    Console.WriteLine("Inserisci un numero");
    int userNumberSelected2 = Convert.ToInt32(Console.ReadLine());

    int r1 = 0;
    int r2 = 1;
    int r3 = 0;
    int r4 = SommaElementiFibonacci2(userNumberSelected1, r1, r2, r3);

    int SommaElementiFibonacci2(int userNumberSelected1, int r1, int r2, int r3)
    {

        for (int i = 1; i < userNumberSelected2; ++i)   
        {
            r3 = r1 + r2;
            r1 = r2;
            r2 = r3;
        }

        return r3;
    }

    Console.WriteLine("il risultato ricorsivo è " + r4);
}
