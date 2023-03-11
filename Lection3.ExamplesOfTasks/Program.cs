// // Функции в прораммировании. 
// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить "К",
// а большие "С" заменить маленькими "с"
string text = "Характер девушки-Близнецы многогранен";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    
    for (int i = 0; i<length; i++)
    {   
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result+ $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

