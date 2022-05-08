using System;
using System.Collections.Generic;

namespace DataStructureProblems
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Welcome to Linked List Program----------");
            bool end = true;
            Console.WriteLine("\n1.Add Data\n2.Reverse Data\n3.InsertData\n4.RemoveFirstElement\n5.RemoveLastElement\n6.Search Node\n7.InsertNewData\n8.StackPush\n9.StackPickPop\n10.End Of Program ");
            while (end)
            {
                DataStructure<string> structure=new DataStructure <string>();
                OrderedList<int> list=new OrderedList<int>();
                Console.WriteLine("\nEnter Option For Exicute The Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Inserted into Linked List");
                        structure.Add("Harshu");
                        structure.Add("Girish");
                        structure.Add("Patil");
                        structure.Display();
                        break;
                    case 2:
                        structure.AddInReverseOrder("Harshu");
                        structure.Add("Girish");
                        structure.Add("Patil");
                        structure.Display();
                        break;
                    case 3:
                        structure.Add("Patil");
                        structure.Add("Harshu");
                        int num = structure.Search("Patil");
                        structure.InsertAtParticularPosition(num + 1, "Girish");
                        structure.Display();
                        break;
                    case 4:
                        structure.Add("Patil");
                        structure.Add("Girish");
                        structure.Add("Harshu");
                        structure.RemoveFirstNode();
                        structure.Display();
                        break;
                    case 5:
                        structure.Add("Patil");
                        structure.Add("Girish");
                        structure.Add("Harshu");
                        structure.RemoveLastNode();
                        structure.Display();
                        break;
                    case 6:
                        structure.Add("Patil");
                        structure.Add("Girish");
                        structure.Add("Harshu");
                        structure.Search("Girish");
                        break;
                    case 7:
                        structure.Add("Patil");
                        structure.Add("Girish");
                        structure.Add("Harshu");
                        int newNode = structure.Search("Girish");
                        structure.InsertAtParticularPosition(newNode + 1, "Rohit");
                        structure.Display();
                        break;
                    case 8:
                        list.Push(70);
                        list.Push(30);
                        list.Push(56);
                        list.Display();
                        break;
                    case 9:
                        list.Push(70);
                        list.Push(30);
                        list.Push(56);
                        list.IsEmpty();
                        break;
                        break;
                    case 10:
                        end = false;
                        Console.WriteLine("Program Is Ended.");
                        break;
                    default:
                        Console.WriteLine("Enter The Correct Option");
                        break;
                }
            }
        }
    }
}
