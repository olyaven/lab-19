string subject = "информатика";
string upperSubject = subject.ToUpper();
string lowerSubject = subject.ToLower();

Console.WriteLine(subject);
Console.WriteLine(upperSubject);
Console.WriteLine(lowerSubject);

Console.WriteLine("Исходная строка: " + subject);

    





    string topic = "Циклы и массивы в языке C#";

Console.WriteLine(topic.Contains("массивы"));
Console.WriteLine(topic.IndexOf("массивы"));
Console.WriteLine(topic.StartsWith("Циклы"));
Console.WriteLine(topic.EndsWith("C#"));

Console.WriteLine(topic.IndexOf("Python"));







string studentsLine = "Аня,Борис,Вика,Григорий";
string[] students = studentsLine.Split(',');

foreach (string student in students)
{
    Console.WriteLine(student);
}

string joined = String.Join(" | ", students);
Console.WriteLine(joined);

Console.WriteLine("Количество студентов: " + students.Length);









string rawId = " 2024-105 ";
string cleaned = rawId.Trim().Replace("-", "");

Console.WriteLine(cleaned);

string year = cleaned.Substring(0, 4);

Console.WriteLine("Год: " + year);







string answer = "ДА";

if (string.Equals(answer, "да", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Ответ распознан");
}
else
{
    Console.WriteLine("Ответ не распознан");
}







string sentence = "Сегодня мы изучаем методы строк";

string upperSentence = sentence.ToUpper();

Console.WriteLine(upperSentence);
Console.WriteLine("Количество символов: " + upperSentence.Length);










string sentence = "Сегодня мы изучаем методы строк";
string word = "методы";

if (sentence.Contains(word))
{
    Console.WriteLine("Слово найдено");
}
else
{
    Console.WriteLine("Слово не найдено");
}








string sentence = "Сегодня мы изучаем язык программирования C Sharp";

string[] words = sentence.Split(' ');

Console.WriteLine("Количество слов: " + words.Length);







string sentence = "Программирование на C#";
string beginning = "Программирование";

if (sentence.StartsWith(beginning))
{
    Console.WriteLine("Строка начинается с заданного текста");
}
else
{
    Console.WriteLine("Строка не начинается с заданного текста");
}








string rawList = " Аня , Борис,Вика , Григорий ";

string[] names = rawList.Split(',');

// Убираем лишние пробелы
for (int i = 0; i < names.Length; i++)
{
    names[i] = names[i].Trim();
}

// Пузырьковая сортировка
for (int i = 0; i < names.Length - 1; i++)
{
    for (int j = 0; j < names.Length - 1 - i; j++)
    {
        if (string.Compare(names[j], names[j + 1]) > 0)
        {
            string temp = names[j];
            names[j] = names[j + 1];
            names[j + 1] = temp;
        }
    }
}

// Объединяем имена
string result = String.Join(", ", names);

Console.WriteLine(result);






