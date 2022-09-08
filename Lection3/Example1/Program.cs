void Method1(string msg, int count) {
    int i = 0;
    while (i < count) {
        Console.Write($"{msg} ");
        i++;
    }
}

string Method2(string msg, int count) {
    int i = 0;
    string res = string.Empty;
    while (i < count) {
        res = res + msg;
        i++;
    }
    return res;
}

Method1("Text", 3);
Console.WriteLine(Method2(msg: "Text", count: 3));