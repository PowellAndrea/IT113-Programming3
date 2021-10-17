//  -----   Main    -----
//  andrea.powell@student.centralia.edu
//  IT-113  *   HW3: Linked List
//
//  todo:
//		Work in Progress
//		Print not done
//		Search broken
//  ---------------------

using System;

namespace Powell_linkedlist
{
	class Program
	{
		static void Main(string[] args)
		{
			LinkedList myList	= new LinkedList();
			Node Head = myList.Head;

			Console.WriteLine(Menu());

         bool keepLooping = true;
         while (keepLooping)
         {
            String strChoice = Console.ReadLine();
            Console.Clear();

            try
            {
               int intChoice = int.Parse(strChoice);
               //Console.WriteLine("I am not string " + intChoice);

               String strItem;

               switch (intChoice)
               {
                  case 1:        // Add a Thing
                     Console.WriteLine("What thing would you like to add?");
                     strItem = Console.ReadLine();
                     Console.Clear();
                     try
                     {
                        Node newNode = new Node(strItem);
                        //myList.Add(Head, newNode);
                        myList.Add(Head, new Node("Sailing"));
                        myList.Add(Head, new Node(strItem));
                        Console.WriteLine("Success!  The new thing is: " + newNode.Data + "\n");
                        Console.WriteLine(Menu());
                     }
                     catch
                     {
                        Console.WriteLine("Something went wrong.  Try again");
                     }
                     break;

                  case 2:     // Remove a Thing
                     Console.WriteLine("What thing would you like to remove?");
                     strItem = Console.ReadLine();
                     break;

                  case 3:     // Search for a thing
                     Console.WriteLine("What thing would you like to find?");
                     strItem = Console.ReadLine();

                     Node test = myList.Contains(Head, "strItem");

                     if (test != null)
                     {
                        Console.WriteLine("We found it! " + strItem + " is your thing.");
                     }
                     else
                     {
                        Console.WriteLine("Sorry, " + strItem + " is not a thing.  Try mountain climbing.");
                     }
                     Console.WriteLine(Menu());
                     break;

                  case 4:     // Print all the things
                     {
                        Console.WriteLine("All the things are:");

                        if (Head == null)
                        {
                           Console.WriteLine("The list is empty.");
                        }
                        Node CurrentNode = Head;

                        while (CurrentNode != null)
                        {
                           Console.WriteLine(CurrentNode.Data);

                           if (CurrentNode.Next != null)
                           {
                              CurrentNode = CurrentNode.Next;
                           }

                           break;
                        }
                        Console.WriteLine(Menu());
                        break;
                     }

                  case 5:     // Exit - ok
                     keepLooping = false;
                     Console.WriteLine("Goodby.  Your things are no more.");
                     break;
               }
            }
            catch             // input is not an int 1-5, throw an error - ok
            {
               Console.WriteLine(strChoice + " is not a valid choice.  Try again.\n");
               Console.WriteLine(Menu());
            }
         }
      }

		static String Menu()
		{
			var newString = "";

			newString = "\n--- Hello, what do you want to do today? ---\n\n";
			newString += "1. Add a thing to the end of the list.\n";
			newString += "2. Remove a thing.\n";
			newString += "3. Search for a thing.\n";
			newString += "4. Print all the things.\n\n";
			newString += "5. The end of things. (Exit)\n\n";
			newString += "--- Enter your choice as a number 1-5. ---\n\n";
			return newString;
		}
	}
}
