// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


string numbersLine = Console.ReadLine();
int[] numbers = GetNumbersFromString(numbersLine);
int count = GetPositiveNumberCount(numbers);
System.Console.WriteLine($"[{numbersLine}] -> {count}");

int[] GetNumbersFromString(string numbersLine)
{
    string[] numberStrings = numbersLine.Split(' ');
    int[] numbers = new int[numberStrings.Length];

    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToInt32(numberStrings[i]);
    }

    return numbers;
}

int GetPositiveNumberCount(int[] numbers)
{
    int count = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > 0)
        {
            count++;
        }
    }
    
    return count;
}