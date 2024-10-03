namespace OOPGenericCollections
{
    //Author Mattias Åström, .NET24
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Employee> myStack = new();
            List<Employee> myList = new();


            Employee Mattias = new Employee(1, 100, "Mattias", "Male");
            Employee Therese = new Employee(2, 200, "Therese", "Famale");
            Employee David = new Employee(3, 300, "David", "Male");
            Employee Erik = new Employee(4, 400, "Erik", "Male");
            Employee Diana = new Employee(5, 500, "Diana", "Female");

            {
                myStack.Push(Mattias);
                myStack.Push(Therese);
                myStack.Push(David);
                myStack.Push(Erik);
                myStack.Push(Diana);
            }

            //loop through all items in the stack and print their values.
            foreach (var item in myStack)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Gender: {item.Gender}, Salary: {item.Salary}");
                Console.WriteLine("Current Stack size: " + myStack.Count);
            }
            BlankSpace();
            //loop through the Stack pop the element print its values and get current count.
            for (int i = 0; i < myStack.Count; i++)
            {
                Employee item = myStack.Pop();
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Gender: {item.Gender}, Salary: {item.Salary}");
                Console.WriteLine("Current Stack size: " + myStack.Count);
                i--;
            }
            //re-add all items to the Stack.
            {
                myStack.Push(Mattias);
                myStack.Push(Therese);
                myStack.Push(David);
                myStack.Push(Erik);
                myStack.Push(Diana);
            }
            BlankSpace();
            //Peek.
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Id: {myStack.Peek().Id}, Name: {myStack.Peek().Name}, Gender: {myStack.Peek().Gender}, Salary: {myStack.Peek().Salary}");
                Console.WriteLine("Current Stack size: " + myStack.Count);
            }
            //Check if specific item exist in the Stack.
            if (myStack.Contains(David))
            {
                Console.WriteLine($"\nId: {myStack.Peek().Id}, Name: {myStack.Peek().Name}, Gender: {myStack.Peek().Gender}, Salary: {myStack.Peek().Salary}");
                Console.WriteLine("Current Stack size: " + myStack.Count);
            }
            BlankSpace();

            //List
            {
                myList.Add(Mattias);
                myList.Add(Therese);
                myList.Add(David);
                myList.Add(Erik);
                myList.Add(Diana);
            }
            //Check if specific item exist in the List.
            if (myList.Contains(Diana))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }

            //find first item that is Male
            Employee person = myList.Find(p => p.Gender == "Male");
            if (person != null)
            {
                Console.WriteLine($"\nId: {person.Id}, Name: {person.Name}, Gender: {person.Gender}, Salary: {person.Salary}");

            }
            BlankSpace();
            //find all items that is Male
            List<Employee> maleList = myList.FindAll(p => p.Gender == "Male");
            for (int i = 0; i < maleList.Count; i++)
            {
                Console.WriteLine($"\nId: {maleList[i].Id}, Name: {maleList[i].Name}, Gender: {maleList[i].Gender}, Salary: {maleList[i].Salary}");
            }
            BlankSpace();
        }

        static void BlankSpace()
        {
            Console.WriteLine("\n -------------------- \n");
        }
    }
}