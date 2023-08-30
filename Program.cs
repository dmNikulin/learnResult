Console.Clear();

string[] library = { "Лисица",  "Тигр", "Кит", "34", "Да" };

Console.Write("Введите количество символов для поиска: ");
int col = Convert.ToInt32(Console.ReadLine());

string[] findSymbols(string[] words, int quantity)     // Функция, которой даешь массив и цифру, 
                                                       // чтобы отсортировать по кол-ву символов.
{
    int count = 0;
    int length = words.Length;

    for (int j = 0; j < length; j++)                    //Посчитаем количество слов по условию, чтобы создать соразмерный массив.
    {
        if (words[j].Length <= quantity)
        {
            count++;
        }
    }

    string[] selectionResult = new string[count];
    count = 0;                                           //Снова обнулим, чтобы далее использовать под новый массив.

    for (int i = 0; i < length; i++)
    {
        if (words[i].Length <= quantity)
        {
            selectionResult[count] = words[i];
            count++;
        }
    }

    return selectionResult;
}

void showList(string[] list)                             // Функция вывода массива
{
    int length = list.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write($"{list[i]}; ");
    }
}

string[] results = findSymbols(library, col);

if (results.Length == 0)
{
    Console.WriteLine("Количество слов с такой размерностью или меньше равна 0!");
}

else showList(results);
