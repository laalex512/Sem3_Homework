/*4. Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается,
когда пишем exit еще 4 команды (их можно придумать самому). Например:
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
Exit – выход
WriteName – вывести имя после ввода пароля

Команды для изменения имени или пароля и просмотра имени требуют ввода текущего пароля (3 попытки)

*/

string Input(string mes)
{
    Console.Write($"Insert {mes}: ");
    return Console.ReadLine();
}
string pass="123456";
string userName = "Username";
string stopWord = "exit";
string helpWord = "help";
string setName = "set name";
string setPass = "set password";
string viewName = "view name";
string insertMessage;
while(true)
{
    insertMessage = Input("command (to see all commands say 'help')");
    if (insertMessage==helpWord)
    {
        Console.WriteLine("'help' - all commands");
        Console.WriteLine("'set name' - set Username");
        Console.WriteLine("'set password' - set new password");
        Console.WriteLine("'view name' - view Username");
        Console.WriteLine("'exit' - close program");
    }
    if (insertMessage == setPass)
    {
        int attempt = 0;
        string attemptPassword;
        int leftTries; 

        while (attempt<3) 
        {
            leftTries = 3-attempt; 
            attemptPassword = Input($"password (left {leftTries} tries left)");
            if (attemptPassword==pass) 
            {
                Console.Write("Right password. ");
                pass = Input("new password");
                break;
            }
            else Console.Write("Fail. ");
            attempt++;
        }
        if (attempt==3) Console.WriteLine("Sorry. You're loose");
    }
    if (insertMessage == setName)
    {
        int attempt = 0;
        string attemptPassword;
        int leftTries; 

        while (attempt<3) 
        {
            leftTries = 3-attempt; 
            attemptPassword = Input($"password (left {leftTries} tries left)");
            if (attemptPassword==pass) 
            {
                Console.Write("Right password. ");
                userName = Input("Username");
                break;
            }
            else Console.Write("Fail. ");
            attempt++;
        }
        if (attempt==3) Console.WriteLine("Sorry. You're loose");
    }
        if (insertMessage == viewName)
    {
        int attempt = 0;
        string attemptPassword;
        int leftTries; 

        while (attempt<3) 
        {
            leftTries = 3-attempt; 
            attemptPassword = Input($"password (left {leftTries} tries left)");
            if (attemptPassword==pass) 
            {
                Console.WriteLine("Right password. Username: " + userName);
                break;
            }
            else Console.Write("Fail. ");
            attempt++;
        }
        if (attempt==3) Console.WriteLine("Sorry. You're loose");
    }
    if (insertMessage==stopWord) 
    {
        Console.WriteLine("Bye!");
        break;
    }
}