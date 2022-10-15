int Max(int arg1, int arg2, int arg3)//задаем функцию под именем Max
{//начало тела метода
    int result = arg1;//объявляем новую переменную и присваиваем ей значение первого аргумента arg1
    if (arg2 > result) result = arg2;//ищем максимальное
    if (arg3 > result) result = arg3;
    return result;//возвращаем результат
}//конец тела метода


//объявляем
int a1 = 15000;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 3763;
int a3 = 13;
int b3 = 23;
int c3 = 331;

/*int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);*///аналогичное реение ниже

//аналог
int max = Max(
    Max (a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Console.WriteLine(max);