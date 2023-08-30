Console.Clear();

string[] library = {"Лисица", "Кот", "Тигр", "Кит", "34", "Да"};

string[] findSymbols (string[] words, int quantity)     // Функция, которой даешь массив и цифру, 
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

void showList(string[] list)
{
    int length = list.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write($"{list[i]}; ");
    }
}

string[] results = findSymbols(library, 3);

showList(results);