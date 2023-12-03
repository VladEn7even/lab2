using System;

// Клас Address
class Address
{
    private int index;
    private string? country;
    private string? city;
    private string? street;
    private string? house;
    private int apartment;

    // Властивості з методами доступу
    public int Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        get { return country; }
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        set { country = value; }
    }

    public string City
    {
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        get { return city; }
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        set { city = value; }
    }

    public string Street
    {
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        get { return street; }
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        set { street = value; }
    }

    public string House
    {
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        get { return house; }
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        set { house = value; }
    }

    public int Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}

class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertToUSD(double uah)
    {
        return uah / usd;
    }

    public double ConvertToEUR(double uah)
    {
        return uah / eur;
    }

    public double ConvertToPLN(double uah)
    {
        return uah / pln;
    }

    public double ConvertFromUSD(double usd)
    {
        return usd * this.usd;
    }

    public double ConvertFromEUR(double eur)
    {
        return eur * this.eur;
    }

    public double ConvertFromPLN(double pln)
    {
        return pln * this.pln;
    }
}

class Employee
{
    private string surname;
    private string name;

    public Employee(string surname, string name)
    {
        this.surname = surname;
        this.name = name;
    }

    public void CalculateSalary(string position, int experience)
    {
        double baseSalary = 1000; // Базова зарплата

        // Розрахунок окладу в залежності від посади та досвіду
        switch (position)
        {
            case "junior":
                baseSalary += 200 * experience;
                break;
            case "middle":
                baseSalary += 300 * experience;
                break;
            case "senior":
                baseSalary += 400 * experience;
                break;
            default:
                Console.WriteLine("Invalid position");
                break;
        }

        double tax = baseSalary * 0.1; // Податок 10%

        Console.WriteLine($"Employee: {surname} {name}, Position: {position}");
        Console.WriteLine($"Salary: {baseSalary}, Tax: {tax}");
    }
}

class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate;

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.registrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"Login: {login}, Name: {firstName} {lastName}, Age: {age}");
        Console.WriteLine($"Registration Date: {registrationDate}");
    }
}

class Program
{
    static void Main()
    {
        // Приклад використання класу Address
        Address address = new Address();
        address.Index = 12345;
        address.Country = "Country";
        address.City = "City";
        address.Street = "Street";
        address.House = "10";
        address.Apartment = 5;

        Console.WriteLine($"Index: {address.Index}, Country: {address.Country}, City: {address.City}");
        Console.WriteLine($"Street: {address.Street}, House: {address.House}, Apartment: {address.Apartment}");

        // Приклад використання класу Converter
        Converter converter = new Converter(28, 33, 7);
        double amountInUAH = 1000;
        Console.WriteLine($"Converted to USD: {converter.ConvertToUSD(amountInUAH)}");

        // Приклад використання класу Employee
        Employee employee = new Employee("Doe", "John");
        employee.CalculateSalary("middle", 3);

        // Приклад використання класу User
        User user = new User("user123", "John", "Doe", 30);
        user.DisplayUserInfo();
    }
}
