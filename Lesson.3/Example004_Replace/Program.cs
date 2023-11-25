/*
    Дан текст. В тексте нужно заменить все пробелы чёрточками,
маленькие буквы "к" заменить большими "К",
а большие "С" заменить маленькими "с".
*/

string text = "- Я думаю, - сказал князь, улыбаясь, - что, " +
              "ежели бы вас послали вместо нашего милого Винценгероде, " +
              "вы бы взяли приступом согласие прусского короля. " +
              "Вы так красноречивы. Вы дадите мне чаю?";

/*
    замена одного символа в строке, на выходе новая строка
*/
string Replace(string text, char source, char dest)
{
    string result = String.Empty;

    for (int idx = 0; idx < text.Length; idx++)
    {
        if (text[idx] == source)
        {
            result += $"{dest}";
        } else {
            result += $"{text[idx]}";
        }
    }
    return result;
}

string newText;

newText = Replace(text, ' ', '_');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText,'С', 'с');
Console.Clear();
Console.WriteLine(text);
Console.WriteLine(newText);
