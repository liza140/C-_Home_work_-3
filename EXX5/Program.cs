// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

// 1. Создание массива и заполнение массива кубами числа.
// 2. Создание печатной формы.


int[] BoxSq(int N)
{
    int m = 1;
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = m * m * m;
        m++;
    }
    return array;
}

string PrintArray(int[] array)
{
    int i = 0;
    int count = array.Length;
    string res = String.Empty;
    while (i < count)
    {
        res = res + $"{i + 1} {array[i]}\n";
        i++;
    }
    return res;
}
int Num = 5;
int[] arr = BoxSq(Num);
string text = PrintArray(arr);
Console.WriteLine(text);

