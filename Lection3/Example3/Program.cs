string ReplaceChar(string text, char oldValue, char newValue) {
    string result = string.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++) {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else
            result = result + $"{text[i]}";   
    }
    return result;
}

string text1 = "fsdfafdafadfadfasdffasf fdasfdfadf - dafdfadfad fadf";

Console.WriteLine(text1);
string text2 = ReplaceChar(text1,'f','a');
Console.WriteLine(text2);
string text3 = ReplaceChar(text2,'a','3');
Console.WriteLine(text3);
