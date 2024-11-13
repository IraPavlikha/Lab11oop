using System;

// Базовий клас "Person"
public class Person
{
    // Публічний доступ
    public string PublicName;
    
    // Приватний доступ
    private int privateAge;
    
    // Захищений доступ
    protected string ProtectedGender;
    
    // Внутрішній доступ
    internal string InternalAddress;

    // Конструктор класу Person
    public Person(string name, int age, string gender, string address)
    {
        PublicName = name;
        privateAge = age;
        ProtectedGender = gender;
        InternalAddress = address;
    }

    // Публічний метод
    public void DisplayInformation()
    {
        Console.WriteLine($"Ім'я: {PublicName}, Вік: {privateAge}, Стать: {ProtectedGender}, Адреса: {InternalAddress}");
        Learn(); // Викликаємо метод Learn() в класі Person
    }

    // Приватний метод
    private void PrivateMethod()
    {
        Console.WriteLine("Це приватний метод.");
    }

    // Захищений метод
    protected void ProtectedMethod()
    {
        Console.WriteLine("Це захищений метод.");
    }

    // Новий метод Learn() для класу Person
    public void Learn()
    {
        Console.WriteLine("Особистість вивчає щось нове.");
    }
}

public class Student : Person
{
    // Конструктор класу Student
    public Student(string name, int age, string gender, string address, string course) 
        : base(name, age, gender, address)
    {
        ProtectedGender = "Невідомо"; // Присвоєння значення захищеному полю
        Course = course;
    }

    // Нове поле внутрішнього доступу
    internal string Course;

    // Метод Study() для класу Student
    public void Study()
    {
        Console.WriteLine($"Студент {PublicName} вивчає.");
        ProtectedMethod(); // Виклик захищеного методу базового класу
    }

    // Перевизначення методу Learn() для класу Student
    public new void Learn()
    {
        Console.WriteLine("Студент вивчає новий предмет.");
        ProtectedMethod(); // Викликаємо захищений метод базового класу
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єкта класу Person
        Person person = new Person("Джон", 25, "Чоловік", "123 Головна вулиця");
        
        // Створення об'єкта класу Student
        Student student = new Student("Аліса", 20, "Жінка", "456 Вулиця Коледжу", "Комп'ютерні науки");

        // Виклик методів для класу Person
        person.DisplayInformation(); // Тепер метод DisplayInformation() викликає Learn()

        // Виклик методів для класу Student
        student.DisplayInformation(); // Тепер метод DisplayInformation() викликає Learn() для студентів
        student.Study(); // Студент вивчає щось
        student.Learn(); // Викликаємо перевизначений метод Learn() для студента
    }
}
