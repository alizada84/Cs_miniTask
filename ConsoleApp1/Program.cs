//Task1

//for (int i = 0; i < 1000; i++)
//{
//    if (i % 3 == 0 && i % 5 == 0)
//        Console.WriteLine(i);
//}


//Task2

//int result = int.Parse(Console.ReadLine());
//for (int i = 0; i < result; i++)
//{
//    Random random = new Random();
//    int random_num = random.Next(0, 100);
//    Console.WriteLine(random_num);
//}


//Task3

//*
//**
//***
//****
//*****

//for (int i = 1; i < 5; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}


//Task4

//Random random = new Random();

//int result = int.Parse(Console.ReadLine());

//int[] random_arr = new int[result];

//for (int i = 0; i < result; i++)
//    random_arr[i] = random.Next(0, 100);


//Console.Write("Cut ededler: ");

//for (int i = 0; i < result; i++)
//{
//    if (random_arr[i] % 2 == 0)
//        Console.Write(random_arr[i] + ", ");
//}

//Console.WriteLine();

//Console.Write("Tek ededler: ");

//for (int i = 0; i < result; i++)
//{
//    if (random_arr[i] % 2 != 0 && random_arr[i] != 2)
//        Console.Write(random_arr[i] + ", ");
//}


//Task 5

//while(true)
//{
//    Console.Write("Enter the number 1: ");
//    int num1 = int.Parse(Console.ReadLine());
//    Console.WriteLine();
//    Console.Write("Enter the number 2: ");
//    int num2 = int.Parse(Console.ReadLine());

//    if ((num1 + num2) % 6 == 0)
//        break;
//}
