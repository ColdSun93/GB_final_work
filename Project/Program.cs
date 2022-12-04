void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"'{array[i]}', ");
        else Console.Write($"'{array[i]}'");
    }
    Console.WriteLine("]");
}

string[] SearchElemLessFour(string[] array)
{
    string[] arrayTwo = new string[array.Length];
    int indexTwoArr = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayTwo[indexTwoArr] = array[i];
            indexTwoArr++;
        }
    }
    Array.Resize(ref arrayTwo, indexTwoArr);
    return arrayTwo;
}

string[] firstArray = { "Hello", "2", "world", ":-)", "in" };
PrintArray(firstArray);
Console.WriteLine();

string[] resultArray = SearchElemLessFour(firstArray);

if (resultArray.Length != 0)
{
    Console.WriteLine("Массив с результатом");
    PrintArray(resultArray);
}
else
Console.WriteLine("Требуемые элементы отсутствуют в исходном массиве");