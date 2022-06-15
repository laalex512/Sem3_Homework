
Console.Write("Insert N:");
int n = int.Parse(Console.ReadLine());

int Cube(int a)
{
    return a*a*a;
}

int i=1;

while (i<=n)
{
    Console.Write(Cube(i)+"  ");
    i++;
}