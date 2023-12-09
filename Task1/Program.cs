//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// Мое решение
// int[,] GreatArray(int x,int y,int min,int max)
// {
//     int[,] arr = new int[x, y];
//     Random rand = new Random();
//     for (int i = 0; i < x; i++)
//     {
//         for (int j = 0; j < y; j++)
//         {
//             arr[i,j]= rand.Next(min, max);
            
//         }
        
//     }
//     return arr;
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i,j]);
//         }
//         Console.WriteLine();
//     }
// }
// int[] ArrayToString(int[,] arr)
// {
//     int[] arrstring = new int[arr.GetLength(0)*arr.GetLength(1)];
//     int index=0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arrstring[index]=arr[i,j];
//             index+=1;
//             //Console.Write(arrstring[index]);
//         }
        
//     }
//     return arrstring;
// }

// void PrintArray2 (int[] arr)
// {
//     foreach (int i in arr)
//     {
//         Console.Write(i);
//     }
// }

// int linesnumber = 3;
// int columnsnumber = 3;
// int minmeaning = 0;
// int maxmeaning = 10;

// int[,] newArray = GreatArray(linesnumber, columnsnumber, minmeaning, maxmeaning);
// PrintArray(newArray);
// int[] stringarray=ArrayToString(newArray);
// PrintArray2(stringarray);

//Другое решение
char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
string result = CreateStringFrom2DArray(charArray);
Console.WriteLine(result);
string CreateStringFrom2DArray(char[,] array)
{
string result = "";

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result += array[i, j]+ " ";
    }
}
return result;
}


