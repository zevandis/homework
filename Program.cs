// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void PrintNumber (int min_number, int max_number)
{
    if (max_number < min_number)
    {
        return;
    }
    PrintNumber(min_number, max_number - 1);
    Console.Write($"{max_number} ");
}


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Не совсем понял в каком должны быть порядке m и n, 
// в примере и в википедии по разному, сделал как в википедии.

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 & n == 0)
    {
        return A(m - 1, 1);
    }
    // if (m > 0 & n > 0)
    else
    {
        return A(m - 1, A(m, n - 1));
    }
}


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void ReverseArray(int[] array, int i) // Вторым аргументом передать длину списка - 1 
{
    if (i < 0)
    {
        return;
    }
    Console.Write($"{array[i]} ");
    ReverseArray(array, i - 1);
}

// PrintNumber(3, 8);
// Console.WriteLine(A(2, 3));
// ReverseArray([2, 10, -3, 0, 1], 4);
