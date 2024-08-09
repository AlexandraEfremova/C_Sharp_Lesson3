//  Создаём функцию, которая в переводе означает вывод квадратов
// тип данных будет VOID потому что функция ничего не возыращает
// INT LIMIT - переменная, до которой бцдет производится квадрат (N)
void PrintSquares(int limit)
{
    int i = 1;
    while(i <= limit)
    {
        System.Console.Write($"{i*i} ");
        i++;
    }
}
// Вызываем функцию и передаём ей аргументы
PrintSquares(5);
PrintSquares(10);
PrintSquares(15);