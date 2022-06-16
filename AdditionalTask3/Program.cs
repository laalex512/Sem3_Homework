/*3. Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. 
Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше.
На отгадывание дается 3 попытки.*/

string Input(string mes)
{
    Console.Write($"Insert {mes}: ");
    return Console.ReadLine();
}

int number = new Random().Next(1,10);

//Console.WriteLine(number);

for (int i = 0; i < 3; i++)
{
    int attemptNum = Convert.ToInt32(Input($"number ({3-i} tries left)"));
    if (attemptNum==number)
    {
        Console.WriteLine("You win!");
        break;
    }
    else if (attemptNum>number)
    {
        Console.WriteLine("No. <");
    }
    else
    {
        Console.WriteLine("No. >");
    }
}

