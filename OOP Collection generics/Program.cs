using System.Collections;

namespace OOP_Collection_generics
{
    internal class Program
    {
        public static bool IsMale(Employee e) //Method used for checking if gender is male
        {
            return e.Gender == "Male";
        }
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "Alex", "Male", 45000);
            Employee emp2 = new Employee(102, "Antonia", "Female", 55000);
            Employee emp3 = new Employee(103, "Amanda", "Female", 35000);
            Employee emp4 = new Employee(104, "Oskar", "Male", 25000);
            Employee emp5 = new Employee(105, "Stefan", "Male", 350000);

            Console.WriteLine("Part One: Stack");

            //Creating a stack and populating it with 5 objects of the employee class
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

            //Removes objects using pop method
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

            //Returning objects using the push method
            stack.Push(emp1);
            stack.Push(emp2);
            stack.Push(emp3);
            stack.Push(emp4);
            stack.Push(emp5);

            Console.WriteLine(" ");
            Console.WriteLine("*******************************");
            Console.WriteLine(" ");
            Console.WriteLine("Retrieving objects using the peek method");

            //Retrieving the top object using peek
            Employee temp1 = (Employee)stack.Peek();
            Console.WriteLine(temp1.ID + " - " + temp1.Name + " - " + temp1.Gender + " - " + temp1.Salary);
            Console.WriteLine("Items left in stack: " + stack.Count);

            stack.Pop(); // Removing the top object in order to peek at the second object from the top

            Employee temp2 = (Employee)stack.Peek(); // Peeking at the second object
            Console.WriteLine(temp2.ID + " - " + temp2.Name + " - " + temp2.Gender + " - " + temp2.Salary);
            Console.WriteLine("Items left in stack: " + stack.Count);

            stack.Push(emp5); //Returning the top object

            Console.WriteLine(" ");
            Console.WriteLine("*******************************");
            Console.WriteLine(" ");

            //Checks if stack contains employee3 using the Contains method
            if (stack.Contains(emp3)) 
            {
                Console.WriteLine("Employee nr.3 is in stack");
            }
            else
            {
                Console.WriteLine("Employee nr.3 is not in stack");
            }

            Console.WriteLine(" ");
            Console.WriteLine("*******************************");
            Console.WriteLine(" ");

            Console.WriteLine("Part Two: List");

            //Creating a list and populating it with 5 objects of the employee class
            List<Employee> empList = new List<Employee>();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);

            //Checks if list contains employee3 using the Contains method
            if (empList.Contains(emp2))
            {
                Console.WriteLine("Employee nr.2 exists in the list");
            }
            else
            {
                Console.WriteLine("Employee nr.2 does not exist in the list");
            }

            Console.WriteLine(" ");
            Console.WriteLine("*******************************");
            Console.WriteLine(" ");

            //Using the Find method to find the first employee whoose gender is male
            Employee tempEmp = empList.Find(e => e.Gender.Contains("Male"));
            Console.WriteLine("First employee with gender \"Male\": \n" +  "ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", tempEmp.ID, tempEmp.Name, tempEmp.Gender, tempEmp.Salary);

            Console.WriteLine(" ");
            Console.WriteLine("*******************************");
            Console.WriteLine(" ");

            //Using the FindAll method to find all employees whoose gender is male
            Console.WriteLine("All employees with gender \"Male\":");

            List<Employee> maleEmployees = empList.FindAll(IsMale); //Creates maleEmployee list, throws all objects in empList through the IsMale method which return true if gender is male and then places those objects into the maleEmployee list 

            foreach(Employee e in maleEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", e.ID, e.Name, e.Gender, e.Salary);
            }
        }
    }
}