// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int[] BoxSq(int N)
{
    int i = 0;
    int m = 1;
    int[] array = new int[N];
    while (i < N)
    {
        array[i] = m * m;
        i++;
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
        res = res + $"{i+1} {array[i]}\n";
        i++;
    }
    return res;
}
int Num = 5;
int[] arr = BoxSq(Num);
string text = PrintArray(arr);
Console.WriteLine(text);

