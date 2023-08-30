Console.Clear();

string[] library = {"Лисица", "Кот", "Тигр", "Кит", "34"};

string[] findSymbols (string[] words, int quantity)
{
    string[] selectionResult = new string[words.Length];
    int length = words.Length;

    for (int i = 0; i < length; i++)
    {
        if (words[i].Length <= quantity)
        {
            selectionResult[i] = words[i];
        }
    }

    return selectionResult;
}

void showList(string[] list)
{
    int length = list.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write($"{list[i]}, ");
    }
}

string[] results = findSymbols(library, 3);

showList(results);