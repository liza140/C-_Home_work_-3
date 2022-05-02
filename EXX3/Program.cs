//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

// 1. Проверка является ли число пятизначным.
// 2. Создание массива. 
// 3. Проверка массива на палиндромом.

int CheckV(int N)
{
    int i = 0;
    if (N < 0) N = 0 - N;
    if (N > 9999 && N < 100000) return i;
    else return i = -1;
}
int[] CountArr(int N)
{
    int[] arr = new int[5];
    int fill = N;
    for (int i = 0; i < 5; i++)
    {
        arr[i] = fill % 10;
        fill = fill / 10;
    }
    return arr;
}

int CheckPol(int[] arr)
{
    int m = 0;
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        if (arr[i] == arr[len - i - 1]) m = 0;
        else
        {
            m = -1;
            break;
        }
    }
    return m;
}
int num = 52333;
int ind = CheckV(num);
if (ind == -1) Console.WriteLine("Введенное число не является пятизначным");
else
{
    int[] A = CountArr(num);
    int ch = CheckPol(A);
    if (ch == 0) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
