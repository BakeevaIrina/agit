int Max(int arg1, int arg2, int arg3)//задаем функцию под именем Max
{//начало тела метода
    int result = arg1;//объявляем новую переменную и присваиваем ей значение первого аргумента arg1
    if (arg2 > result) result = arg2;//ищем максимальное
    if (arg3 > result) result = arg3;
    return result;//возвращаем результат
}//конец тела метода

//              0   1   2   3   4   5   6   7   8
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };//массив данных
/*array[0] = 12;//присвоить новое значение 
Console.WriteLine(array[4]);*///вывести определенные данные

//поиск максимального значения в массиве
int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);

