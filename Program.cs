using System;
using System.Collections.Generic;

class Employee
{
    public int ID { get; set; } // ID 
    public string FIO { get; set; } // ФИО 
    public string Position { get; set; } // Должность
    public int Salary { get; set; } // ЗП
}

class Program
{
    static void Main(string[] args)
    {

        List<Employee> Company = new List<Employee>();
        Company.Add(new Employee()
        {
            ID = 1,
            FIO = "Махотина А.",
            Position = "Инженер",
            Salary = 38000
        });

        Company.Add(new Employee()
        {
            ID = 2,
            FIO = "Гуськов Б.",
            Position = "Менеджер",
            Salary = 45000
        });

        Company.Add(new Employee()
        {
            ID = 3,
            FIO = "Луценко А.",
            Position = "Директор",
            Salary = 60000
        });
        Company.Add(new Employee()
        {
            ID = 4,
            FIO = "Кемаев А.",
            Position = "Инженер",
            Salary = 38000
        });
        Company.Add(new Employee()
        {
            ID = 5,
            FIO = "Антонова С.",
            Position = "Менеджер",
            Salary = 40000
        });
    }
}
