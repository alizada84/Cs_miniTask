namespace ConsoleApp3;

internal class User
{
    public string _name;
    public string _surname;
    public byte _age;
    public static string _password = "Ibra123";

    public User(string name, string surname, byte age)
    {
        _name = name;
        _surname = surname;
        _age = age;
    }

    public override string ToString()
    {
        return $"Name: {_name}\nSurname: {_surname}\nAge: {_age}\nPasswords: {_password}";
    }
}
