// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string stroka = "aSdFgHjKlP";
Console.Write(SmollLetter(stroka));
string SmollLetter(string str)
{
    string result = str.ToLower();
    return result;
}