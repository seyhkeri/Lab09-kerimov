// // // // // // // // // Console.Write("Введите слово: ");
// // // // // // // // // string word = Console.ReadLine();

// // // // // // // // // string lower = word.ToLower();
// // // // // // // // // int count = 0;

// // // // // // // // // for (int i = 0; i < lower.Length; i++)
// // // // // // // // // {
// // // // // // // // //     if (lower[i] == 'а')
// // // // // // // // //     {
// // // // // // // // //         count++;
// // // // // // // // //     }
// // // // // // // // // }

// // // // // // // // // Console.WriteLine(count);

// // // // // // // // Console.Write("Имя файла: ");
// // // // // // // // string file = Console.ReadLine();

// // // // // // // // if (file.EndsWith(".cs"))
// // // // // // // // {
// // // // // // // //     Console.WriteLine("Это файл C#");
// // // // // // // // }
// // // // // // // // else if (file.EndsWith(".png") || file.EndsWith(".jpg"))
// // // // // // // // {
// // // // // // // //     Console.WriteLine("Это изображение");
// // // // // // // // }
// // // // // // // // else
// // // // // // // // {
// // // // // // // //     Console.WriteLine("неизвестный тип");
// // // // // // // // }

// // // // // // // // if (file.StartsWith("Lab"))
// // // // // // // // {
// // // // // // // //     Console.WriteLine("Это лабораторная работа");
// // // // // // // // }

// // // // // // // // if (file.Contains("test"))
// // // // // // // // {
// // // // // // // //     Console.WriteLine("Тестовый файл");
// // // // // // // // }

// // // // // // // Console.Write("Введите фразу: ");
// // // // // // // string text = Console.ReadLine();

// // // // // // // Console.WriteLine(text.ToUpper());

// // // // // // // Console.WriteLine(text.Replace(" ", "_"));

// // // // // // // if (text.ToLower().Contains("стоп"))
// // // // // // // {
// // // // // // //     Console.WriteLine("Стоп-слово найдено!");
// // // // // // // }

// // // // // // Console.Write("Введите дату (ГГГГ-ММ-ДД): ");
// // // // // // string date = Console.ReadLine();

// // // // // // string year = date.Substring(0, 4);
// // // // // // string month = date.Substring(5, 2);
// // // // // // string day = date.Substring(8, 2);

// // // // // // Console.WriteLine($"{day}.{month}.{year}");

// // // // // // Console.Write("Введите телефон (11 цифр): ");
// // // // // // string phone = Console.ReadLine();

// // // // // // string part1 = phone.Substring(1, 3);
// // // // // // string part2 = phone.Substring(4, 3);
// // // // // // string part3 = phone.Substring(7, 2);
// // // // // // string part4 = phone.Substring(9, 2);

// // // // // // Console.WriteLine($"+7 ({part1}) {part2}-{part3}-{part4}");

// // // // // Console.Write("Введите строку: ");
// // // // // string input = Console.ReadLine();

// // // // // int total = input.Length;
// // // // // int spaces = 0;
// // // // // int vowelsCount = 0;

// // // // // string vowels = "аеёиоуыэюя";
// // // // // string lower = input.ToLower();

// // // // // for (int i = 0; i < lower.Length; i++)
// // // // // {
// // // // //     if (lower[i] == ' ')
// // // // //     {
// // // // //         spaces++;
// // // // //     }

// // // // //     if (vowels.Contains(lower[i].ToString()))
// // // // //     {
// // // // //         vowelsCount++;
// // // // //     }
// // // // // }

// // // // // Console.WriteLine($"Количество символов: {total}");
// // // // // Console.WriteLine($"Количество пробелов: {spaces}");
// // // // // Console.WriteLine($"Количество гласных букв: {vowelsCount}");

// // // // Console.Write("Введите слово: ");
// // // // string word = Console.ReadLine();

// // // // string reversed = "";

// // // // for (int i = word.Length - 1; i >= 0; i--)
// // // // {
// // // //     reversed += word[i];
// // // // }

// // // // Console.WriteLine(reversed);

// // // // if (word.ToLower() == reversed.ToLower())
// // // // {
// // // //     Console.WriteLine("палиндром");
// // // // }

Console.Write("Введите email: ");
string email = Console.ReadLine();

int atcount = 0;
for (int i = 0; i < email.Length; i++)
{
    if (email[i] == '@')
    {
        atcount++;
    }
}

if (email.Length < 5)
{
    Console.WriteLine("Адрес некорректен: Длина не меньше 5 символов.");
}
else if (atcount != 1)
{
    Console.WriteLine("Адрес некорректен: Есть ровно один символ @.");
}
else if (email.StartsWith("@") || email.EndsWith("@"))
{
    Console.WriteLine("Адрес некорректен: Адрес не начинается и не заканчивается на @.");
}
else if (email.Contains(" "))
{
    Console.WriteLine("Адрес некорректен: В адресе нет пробелов.");
}
else if (!(email.ToLower().EndsWith(".ru") || email.ToLower().EndsWith(".com")))
{
    Console.WriteLine("Адрес некорректен: Адрес заканчивается на .ru или .com.");
}
else
{
    Console.WriteLine("Адрес корректен");
    Console.WriteLine(email.ToLower());
}

// // using System.Text;

// // Console.Write("Введите строку: ");
// // string input = Console.ReadLine();

// // StringBuilder sb = new StringBuilder();
// // string vowels = "аеёиоуыэюя";

// // for (int i = 0; i < input.Length; i++)
// // {
// //     if (!vowels.Contains(input[i].ToString().ToLower()))
// //     {
// //         sb.Append(input[i]);
// //     }
// // }

// // Console.WriteLine(sb.ToString());

// using System.Text;

// Console.Write("Введите строку: ");
// string input = Console.ReadLine();

// StringBuilder sb = new StringBuilder();
// string vowels = "аеёиоуыэюя";

// for (int i = 0; i < input.Length; i++)
// {
//     if (!vowels.Contains(input[i].ToString().ToLower()))
//     {
//         sb.Append(input[i]);
//     }
// }

// Console.WriteLine(sb.ToString());
