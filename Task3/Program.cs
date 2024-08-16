// Создаём функцию, которая будет обнулять чётные элементы массива
void ZeroEventElement(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}
// Создаём функцию для вывода нового массива
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        System.Console.Write($"{arr[e]} ");
    }
}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
ZeroEventElement(array);
PrintArray(array);