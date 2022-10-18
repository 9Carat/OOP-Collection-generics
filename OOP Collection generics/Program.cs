using System.Collections;

namespace OOP_Collection_generics
{
    internal class Program
    {
        //public static void Display<T>(Stack)
        //{
        //    foreach (T item in stack)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}

        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "Alex", "Male", 45000);
            Employee emp2 = new Employee(102, "Antonia", "Female", 55000);
            Employee emp3 = new Employee(103, "Amanda", "Female", 35000);
            Employee emp4 = new Employee(104, "Oskar", "Male", 25000);
            Employee emp5 = new Employee(105, "Stefan", "Male", 350000);

            Stack<object> stack = new Stack<object>();

            stack.Push(emp1);
            stack.Push(emp2);
            stack.Push(emp3);
            stack.Push(emp4);
            stack.Push(emp5);

            Console.WriteLine("Printing out objects in stack");

            foreach(Employee item in stack)
            {
                Console.WriteLine(item.ID + " - " + item.Name + " - " + item.Gender + " - " + item.Salary);
                Console.WriteLine("Items left in stack: " + stack.Count);
            }
            Console.WriteLine(" ");
            Console.WriteLine("*******************************");
            Console.WriteLine(" ");

            Console.WriteLine("Retrieving objects using the pop method");

            Employee tempEmp1 = (Employee)stack.Pop();
            Console.WriteLine(tempEmp1.ID + " - " + tempEmp1.Name + " - " + tempEmp1.Gender + " - " + tempEmp1.Salary);
            Console.WriteLine("Items left in stack: " + stack.Count);
            Employee tempEmp2 = (Employee)stack.Pop();
            Console.WriteLine(tempEmp2.ID + " - " + tempEmp2.Name + " - " + tempEmp2.Gender + " - " + tempEmp2.Salary);
            Console.WriteLine("Items left in stack: " + stack.Count);
            Employee tempEmp3 = (Employee)stack.Pop();
            Console.WriteLine(tempEmp3.ID + " - " + tempEmp3.Name + " - " + tempEmp3.Gender + " - " + tempEmp3.Salary);
            Console.WriteLine("Items left in stack: " + stack.Count);
            Employee tempEmp4 = (Employee)stack.Pop();
            Console.WriteLine(tempEmp4.ID + " - " + tempEmp4.Name + " - " + tempEmp4.Gender + " - " + tempEmp4.Salary);
            Console.WriteLine("Items left in stack: " + stack.Count);
            Employee tempEmp5 = (Employee)stack.Pop();
            Console.WriteLine(tempEmp5.ID + " - " + tempEmp5.Name + " - " + tempEmp5.Gender + " - " + tempEmp5.Salary);
            Console.WriteLine("Items left in stack: " + stack.Count);

            Console.WriteLine("Returning objects using the push method...");
            stack.Push(emp1);
            stack.Push(emp2);
            stack.Push(emp3);
            stack.Push(emp4);
            stack.Push(emp5);

            Console.WriteLine(" ");
            Console.WriteLine("*******************************");
            Console.WriteLine(" ");

            Console.WriteLine("Retrieving objects using the peek method");

            Employee temp1 = (Employee)stack.Peek();
            Console.WriteLine(temp1.ID + " - " + temp1.Name + " - " + temp1.Gender + " - " + temp1.Salary);
            Console.WriteLine("Items left in stack: " + stack.Count);
            stack.Pop();
            Employee temp2 = (Employee)stack.Peek();
            Console.WriteLine(temp2.ID + " - " + temp2.Name + " - " + temp2.Gender + " - " + temp2.Salary);
            Console.WriteLine("Items left in stack: " + stack.Count);
            stack.Push(emp5);

            Console.WriteLine(" ");
            Console.WriteLine("*******************************");
            Console.WriteLine(" ");

            if (stack.Contains(emp3))
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }
        }
    }
}