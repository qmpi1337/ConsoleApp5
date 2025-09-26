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



    }
}
