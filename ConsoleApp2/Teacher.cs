namespace ConsoleApp2;

public class Teacher
{
    public static byte schoolNo;
    public string name;
    public string surname;
    public int price;
    public byte age;

    public Teacher(string name, string surname, int price, DateTime birthDate)
    {
        this.name = name;
        this.surname = surname;
        this.price = price;
        age = (byte)(DateTime.Now.Year - birthDate.Year);
    }

    public Teacher()
    {
        
    }

    public void GetFields() => Console.WriteLine($"Name: {name}, Surname: {surname}, Price: {price}, Age: {age}, School No: {schoolNo}");

}
