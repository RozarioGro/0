/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Clear();
int massage = ConnvertInt("Enter masage");
int[] array = GetArray(massage);
PrintArray(array);
Console.WriteLine($"Positive number - {PosNum(array)}");

int ConnvertInt(string massage){

    Console.WriteLine("Enter the numbers separated by Enter: ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ConnvertInt($"Enter ({i} + 1)");
    }
    return array;
}

void PrintArray(int[] array)
{
     for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int PosNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

