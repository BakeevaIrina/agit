
//метод заполнения массива
void FillArray(int[] collection)//void имя метода int имя аргумента
{
    int length = collection.Length;//определить длинну массива имя.legth
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(1, 10);//задать рандомное значение
        index++;
    }
}


//метод печати массива на экран
void PrintArray(int[] col)//метод, который будет печатать значения
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int possition =-1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            possition = index;
            break;
        }
        index ++;
    }
    return possition;
}

int[] array = new int[10];//создай новый массив с 10ю элементами; по умолчанию он будет заполнян 0

FillArray(array);//функция/метод заполнила пустой массив значениями
array[4]=4;
array[6]=4; 
PrintArray(array);//напечатала массив

Console.WriteLine();

int pos = IndexOf(array, 74);
Console.WriteLine(pos);