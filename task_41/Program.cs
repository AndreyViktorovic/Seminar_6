// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int Chislo(string a)
{
    Console.WriteLine(a);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[] GetRandomArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Chislo($"Введите {i + 1} элемент");
    }
    return array;
}

void ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]} ");
    }
}
int ChisloNum(int[] array)
{
    int b = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            b++;
        }
    }
    return b;
}
int length = Chislo("Введите количество элементов ->  ");
int[] array;
array = GetRandomArray(length);
ReverseArray(array);
Console.WriteLine($"Количество чисел больше 0 ->{ChisloNum(array)} ");
