// Задача 1: Есть монотонная последовательность, каждое число встречается 
// ровно то количество раз, какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
// Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"


System.Console.WriteLine("Введите число N =>");
int count = Convert.ToInt32(Console.ReadLine());
Recursion(count);
void Recursion(int count, int number = 0, int sum = 0)
{
    if (count == 0)
    {
        return;
    }
    for (int i = 0; sum < count; i++)
    {
        sum += i; //sum = sum + i;
        number = i;
    }
    Recursion(--count);
    System.Console.Write(number + " ");
}