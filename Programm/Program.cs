void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToString(Console.ReadLine()!);
    }
}

void NewArray(string[] arrayOld, string[] arrayNew)
{
    for (int i = 0; i < arrayNew.Length; i++)
    {
        if (arrayOld[i].Length < 4)
        {
            arrayNew[i] = arrayOld[i];
        }
    }
}

Console.Clear();
Console.Write("Введите количество элементов: ");
int n = int.Parse(Console.ReadLine()!);
string[] array = new string[n];
string[] arrayNew = new string[n];
Console.WriteLine("Введите элементы массива: ");
InputArray(array);
Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
NewArray(array, arrayNew);
arrayNew = arrayNew.Where(x => x != null).ToArray();
Console.WriteLine($"Новый массив: [{string.Join("; ", arrayNew)}]");