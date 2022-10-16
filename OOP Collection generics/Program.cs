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

            Console.WriteLine(stack.Peek());
            
           
        }
    }
}