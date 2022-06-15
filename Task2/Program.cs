Console.Write("Insert X1:");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Insert Y1:");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Insert Z1:");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Insert X2:");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Insert Y2:");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Insert z2:");
int z2 = int.Parse(Console.ReadLine());

int xDiff= x1-x2;
int yDiff= y1-y2;
int zDiff= z1-z2;

double result = Math.Sqrt(xDiff*xDiff + yDiff*yDiff+ zDiff*zDiff);

Console.Write(result);
