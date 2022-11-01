// Vid1
// void Method1()
// {
//     Console.WriteLine("Autor ....");
// }
// Method1();

// Vid2

// void Method2 (String msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Text lether");

// void Method21 (String msg, int count)
// {
//     int i =0;
//     while(i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method21("Text", 4);
// Method21(msg: "Text new", count: 4);

// Vid3
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// Vid4

// string Method4 (int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i<count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "Z");
// Console.WriteLine(res);

// string Method4 (int count, string c)
// {
//     string result = String.Empty;
//     for (int i=0; i<count; i++)
//     {
//         result = result + c;
//     }
//     return result;
// }
// string res = Method4(10, "Z");
// Console.WriteLine(res);

//Таблица умножения
// for (int i=2; i<=10; i++)
// {
//     for (int j=2; j<=10;j++)
//     {
//         Console.WriteLine($"{i}*{j} = {i*j}");
//     }
//     Console.WriteLine();
// }

//  Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
// заменить большими «К», а большие «С» заменить на маленькие «с».

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля, "
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012
// S[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int Length = text.Length;
    for (int i =0; i < Length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);