using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employees = new Employee("fio", 10000, 1);
            List<Employee> employee = new List<Employee>()
            {
                new Employee("Сергеев Сергей Сергеевич", 10000, 1),
                new Employee("Петров Петр Петрович", 15000, 4),
                new Employee("Иванов Иван Иванович", 20000, 2),
                new Employee("Николаев Николай Николаевич", 25500, 3),
                new Employee("Aлексеев Алексей Алексеевич", 30000, 5),
            };
            TargetA();
            TargetB();
            TargetC();
            TargetD();
            TargetE();
            TargetF();
            

            void TargetA()
            {
                Console.WriteLine("Task A");
                foreach (var emp in employee)
                {
                    Console.WriteLine($"Id: {employees.Id()} ФИО: {emp.fio}, Зарплата: {emp.wages}, Отдел: {emp.department}");
                }
            }
            void TargetB()
            {
                Console.WriteLine("\n" + "Task B");
                double sum = 0;
                foreach (var emp in employee)
                {
                    sum += emp.wages;
                }
                Console.WriteLine($"Сумма затрат на ЗП {sum} в месяц");
            }
            void TargetC()
            {
                Console.WriteLine("\n" + "Task C");
                double min = 500000;
                foreach (var emp in employee)
                {
                    if (emp.wages < min)
                    {
                        min = emp.wages;
                    }
                }
                Console.WriteLine($"Минимальная ЗП: {min}");
            }
            void TargetD()
            {
                Console.WriteLine("\n" + "Task D");
                double max = 0;
                foreach (var emp in employee)
                {
                    if (emp.wages > max)
                    {
                        max = emp.wages;
                    }
                }
                Console.WriteLine($"Максимальная ЗП: {max}");
            }
            void TargetE()
            {
                Console.WriteLine("\n" + "Task E");
                int count = 0;
                double sum = 0;
                foreach (var emp in employee)
                {
                    count++;
                    sum += emp.wages;
                }
                Console.WriteLine($"Среднее значение ЗП: {sum / count}");
            }
            void TargetF()
            {
                Console.WriteLine("\n" + "Task F");
                foreach (var emp in employee)
                {
                    Console.WriteLine($"ФИО: {emp.fio}");
                }
            }
            Console.ReadKey();
        }
    }
}
