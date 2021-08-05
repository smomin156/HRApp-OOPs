using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;
namespace HRApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = $"1. Display All Employees \n2.Insert Confirm Employee\n3.Insert Trainee\n4.Remove Employee by name\n5.Display Employee by Name\n6.Exit";
            Dictionary<string, Employee> employees = new Dictionary<string, Employee>();
            char c='y';
            do
            {
                Console.WriteLine(prompt);
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            foreach(var obj in employees)
                            {
                                Console.WriteLine(obj.Value.ToString());
                                Console.WriteLine("Net Salary :" + obj.Value.CalculateSalary());
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Name:");
                            string nameC = Console.ReadLine();
                            Console.WriteLine("Enter address:");
                            string addressC = Console.ReadLine();
                            Console.WriteLine("Enter Designation:");
                            string designation = Console.ReadLine();
                            try
                            {
                                Console.WriteLine("Enter Basic Salary> 5000:");
                                int basic = Convert.ToInt32(Console.ReadLine());
                                ConfirmEmployee confirmEmployee = new ConfirmEmployee(nameC, addressC, basic, designation);
                                employees.Add(nameC, confirmEmployee);
                            }
                            catch (MinimumSalaryException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter Name:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter address:");
                            string address = Console.ReadLine();
                            Console.WriteLine("Enter number of days:");
                            int days = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter rate per day");
                            double rate = Convert.ToDouble(Console.ReadLine());
                            TraineeEmployee trainee = new TraineeEmployee(name, address, days, rate);
                            employees.Add(name, trainee);
                            break;
                        }

                    case 4:
                        Console.WriteLine("Enter Name of Employee to remove:");
                        string nameDelete = Console.ReadLine();
                        employees.Remove(nameDelete);
                        break;
                    case 5:
                        Console.WriteLine("Enter Name of Employee to display:");
                        string nameShow = Console.ReadLine();
                        Console.WriteLine(employees[nameShow]);
                        break;
                    case 6:
                        break;
                        
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.WriteLine("Do you want to continue y/n ?");
                c = Convert.ToChar(Console.ReadLine());
            }
            while (c != 'n');

            Console.ReadLine();
        }

    }
}
