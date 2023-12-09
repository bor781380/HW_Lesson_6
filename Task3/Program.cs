//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string stroka = "123454321";
Polindrom(stroka);
void Polindrom(string str)
{
    char[] array=str.ToCharArray();
    bool count = true;
    for(int i=0; i<array.Length/2;i++)
    {
        if (array[i] != array[array.Length-1-i])
        {
           count = false; 
           break;
        }
    }
    Console.Write(count);
}