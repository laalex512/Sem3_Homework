Console.WriteLine("Insert number");
int num = Convert.ToInt32(Console.ReadLine());
int numReverse = 0;
int copy = num;


while (copy > 0)
{
    numReverse = numReverse * 10 + copy % 10;
    copy /= 10;
}
if (num==numReverse)
{
    Console.WriteLine("Yes, It's palindrom ");
}
else    
{
    Console.WriteLine("No, It isn't palindrom ");
}

