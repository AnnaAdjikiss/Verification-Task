// Условие задачи:
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Пример: ["hello", "2", "world", ":-)"]  ->  ["2", ":-)"]

// метод создает исходный массив, в случае заполнения его пользователем
string[] CreateInitArray()
{
    Console.WriteLine("введите количество строк обрабатываемого массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    string[] initArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"введите {i + 1} строку: ");
        initArray[i] += Console.ReadLine();
    }
    return initArray;
}

// метод выводит исходный массив
void PrintInitArray(string[] array)
{
    Console.Write("Исходный массив: ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.Write($"{array[array.Length - 1]}");
}

// метод обрабатывает исходный массив и выдает новый:
// (с подходящими по условию значениями, а неподходящие заменяет на <empty>)
string[] CreateResultArray(string[] array, int lim)
{
    int size = array.Length;
    string[] resultArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= lim) resultArray[i] = array[i];
        else resultArray[i] = string.Empty;
    }
    return resultArray;
}

// метод выводит результирующий массив
void PrintResultArray(string[] array)
{
    Console.Write("Результат: ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] != string.Empty) Console.Write($"{array[i]}  ");
    }
    Console.Write($"{array[array.Length - 1]}");
}

int limit = 3; // макс. кол-во символов в строках результирующего массива (цифра из условия задачи)

//т.к. в условии задачи неочевидно, откуда берется исходный массив - делаем запрос
Console.WriteLine("Желаете ввести исходный массив с клавиатуры? (да/нет)");
string answer = Console.ReadLine()!;
switch (answer)
{
    case "да":
        {
            string[] arrayInit = CreateInitArray();
            PrintInitArray(arrayInit);
            Console.WriteLine();
            PrintResultArray(CreateResultArray(arrayInit, limit));
            break;
        }
    case "нет":
        {
            string[] arrayInit = { "hello", "2", "world", ":-)" };
            Console.WriteLine("Данные из примера");
            PrintInitArray(arrayInit);
            Console.WriteLine();
            PrintResultArray(CreateResultArray(arrayInit, limit));
            break;
        }
    default:   
        {
            Console.WriteLine("введено некорректное знаение (работает только 'да' или 'нет')");
            Console.WriteLine("перезапустите программу и введите корректное значение");
            break;
        }
}
