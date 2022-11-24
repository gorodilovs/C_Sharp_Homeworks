Console.Clear();
//Console.SetCursorPosition(10, 4);
//Conosle.WriteLine("+");

int xa = 25, ya = 1;

int xb = 1, yb = 20;

int xc = 50, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("a");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("b");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("c");

int x = xa, y = ya;
int count = 0;
while (count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }

    if (what == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }

    if (what == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+"); 
    count++;
}