// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

System.Console.WriteLine("Введите число n =>");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число m =>");
int m = Convert.ToInt32(Console.ReadLine());

int result = A(n, m);
System.Console.WriteLine($"Функция Аккермана : {result} ");
int A(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if ((n != 0) && (m == 0))
        {
            return A(n - 1, 1);
        }
        else
        {
            return A(n - 1, A(n, m - 1));
        }
    }
}

