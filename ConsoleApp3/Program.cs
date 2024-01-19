//    User classı yaradın.Userin name, surname və age fieldləri olsun.
//    İstifadəçidən ad soyad və yaş daxil etməyini istəyin.Userdə password fieldi yaradın və bu field bütün istifadəçilər üçün eyni olsun 
//    classı istifadə edərkən dəyişdirilə bilsin.Və bununla yeni obyekt yaradın.
//    Bu fieldlərin biri olmasa obyekt yarada bilməsin.Sonra User classında bir method yaradın və məlumatları konsola yazdırın.


using ConsoleApp3;

while (true)
{
    Console.Write("Enter the name: ");
    string? name = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Enter the surname: ");
    string? surname = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Enter the age: ");
    byte age = byte.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Yellow;

    User user = new User(name, surname, age);
    Console.WriteLine(user);

    Console.ForegroundColor = ConsoleColor.White;

    break;
}