// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.
//“Hello my world” => “world my Hello”

string stroka = "Hello my world";

// Мой способ
// reversLine(stroka);
// void reversLine(string str)
// {
//     string[] array = str.Split(" ");
//     string[] rezult = new string[array.Length];
//     for(int i=0; i<array.Length; i++)
//     {
//         rezult[i] = array[array.Length-1-i];
//         Console.Write(rezult[i]+" ");
//     }
// }

//Из книжки
string result = ReverseWords(stroka);
Console.WriteLine(result);

string ReverseWords(string str)
{
    string[] words = str.Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words);
}