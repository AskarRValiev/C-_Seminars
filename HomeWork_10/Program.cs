//Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
/*
int VowelLetter(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i][0] == 'a' || array[i][0] == 'e' || array[i][0] == 'i' || 
        array[i][0] == 'o' || array[i][0] == 'u' || array[i][0] == 'y')
        {
            count++;
        }
    }
    return count;
}

string[] words = {"aqwe", "wer", "ert", "yrty", "tyu", "igh", "rtj", "ort"};

int vowelsCount = VowelLetter(words);
Console.WriteLine("There are " + vowelsCount + " words with vowels beginning.");
*/
//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

string[] ConcString(string[] array)
{   string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i = i + 2)
    {
        newArray[i] = array[i] + array[i + 1];
    }
    return newArray;
}

string[] words = {"aqwe", "wer", "ert", "yrty", "tyu", "igh", "rtj", "jgh"};
string[] newWords = ConcString(words);
for (int i = 0; i < newWords.Length; i++)
{
    Console.Write(newWords[i] + " ");
}

