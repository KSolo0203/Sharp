string Method2(string msg, int count) {
    string res = string.Empty;
    for (int i = 0; i < count; i++) {
        res = res + msg;
    }
    return res;
}

// Console.WriteLine(Method2("Text",3));

for (int i = 1; i <= 10; i++) {
    for (int j = 1; j <= 10; j++) {
        Console.Write ($"{j}*{i} = {i*j}     ");
    }
    Console.WriteLine();
}

