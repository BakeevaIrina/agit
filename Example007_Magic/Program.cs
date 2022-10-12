Console.Clear();//очистка консоли
//Console.SetCursorPosition(10, 4);//рисование
//Console.WriteLine("*");

/*int xa = 1;
int ya = 1;
int xb = 1;
int yb = 30; Ниже аналог этой записи точек*/
int xa = 40, ya = 1, 
    xb = 1, yb = 30, 
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");


int x = xa, y = xb;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3);
    if(what == 0)
    {
        x = (x + xa)/2;
        x = (y + ya)/2;

    }

        if(what == 1)
    {
        x = (x + xb)/2;
        x = (y + yb)/2;

    }

        if(what == 2)
    {
        x = (x + xc)/2;
        x = (y + yc)/2;

    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count ++;//+=1
}
