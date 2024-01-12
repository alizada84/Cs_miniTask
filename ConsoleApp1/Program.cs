
using ConsoleApp1;

Bank user1 = new Bank(500, 1629);

int wrongPassCount = 0;

while (true)
{
    Console.Write("Enter your password: ");
    int userPassword = int.Parse(Console.ReadLine());

    if (userPassword == user1.Password)
    {
        Console.WriteLine("Password correct. Welcome!");
        bool isCheck = true;
        while (isCheck)
        {
            int value = Functions.MainMenu();

            switch (value)
            {
                case 1:
                    Console.WriteLine(user1.Balance);

                    Console.Write("Press 0 to return to the list or 9 to exist program: ");
                    int item = int.Parse(Console.ReadLine());
                    if (item == 0)
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (item == 9)
                        return;
                    break;
                case 2:
                    try
                    {
                        Console.Write("Pulun miqdarini daxil edin: ");
                        int addBalance = int.Parse(Console.ReadLine());

                        user1.AddBalance(addBalance);

                        Console.Write("Press 0 to return to the list or 9 to exist program: ");
                        item = int.Parse(Console.ReadLine());
                        if (item == 0)
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (item == 9)
                            return;
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    break;
                case 3:
                    try
                    {
                        Console.Write("Pulun miqdarini daxil edin: ");
                        int removeBalance = int.Parse(Console.ReadLine());

                        user1.RemoveBalance(removeBalance);

                        Console.Write("Press 0 to return to the list or 9 to exist program: ");
                        item = int.Parse(Console.ReadLine());
                        if (item == 0)
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (item == 9)
                            return;
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    break;
                case 4:
                    Console.Clear();
                    isCheck = false;
                    break;
                default:
                    Console.WriteLine("Please enter the correct value. ");
                    break;
            }
        }
    }
    else
    {
        wrongPassCount++;
        Console.WriteLine($"Incorrect password. {3 - wrongPassCount}");

        if (wrongPassCount >= 3)
        {
            Console.WriteLine("Too many incorrect attempts. Exiting program.");
            return;
        }
    }
}
