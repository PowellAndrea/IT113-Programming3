//  -----   Linked List Class    -----
//  andrea.powell@student.centralia.edu
//  IT-113  *   HW3: Linked List
//
//   The linkedlist Class supports a single linked list limited to string data.
//
//   String comparisons are case-insensitive
//   The items in this class are not sorted.
//   Items are always added to the end of the list.
//
//  todo:
//
//   ---------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powell_linkedlist
{
	class LinkedList
	{
		public Node Head;

		public LinkedList()
		{
			Head = null;
		}
		public LinkedList(Node newNode)
      {
			Head = newNode;
      }

		//	Add an (unsorted) item
		public Node Add(Node Head, Node NewThing)
		{
			// If list is empty, make this the first thing
			if (Head == null)
			{
				Head = NewThing;
				return NewThing;
			}
			Node CurrentNode = Head;

			while (CurrentNode != null)
			{
				//Find the last thing and append this new thing.
				if (CurrentNode.Next == null)
				{
					CurrentNode.Next = NewThing;
					return NewThing;
				}
				else
				{
					CurrentNode = CurrentNode.Next;
				}
			}
			return Head;
		}

		//  Contains: Returns a node with a matching item; if no match, return null
		public Node Contains(Node Head, String strSearch)
      {
			if (Head == null || strSearch == null)
         {
				return null;
         }

			Node Current = Head;
			if (Current.Data == strSearch)
			{
				return Current;
         }

			while (Current.Next != null)
			{
				if (Current.Data == strSearch)
				{
					return Current;
				}
				else
				{
					Current = Current.Next;
				}
			}
			return null;
      }

		//  Removes node containing the item and links the two adjacent nodes together
		public Boolean Delete(Node Head, String strThing)
      {
			if ((Head == null) || (strThing == null))
         {
				return false;
         }
			else
         {
            //do the remove
            try
            {
					return true;
				}
				catch 
				{
					return false;
				}
         }
      }

		// Prints the entire list front to back.Breaking encapsulation here is permitted
		public bool PrintAllNodes()
      {
         try
         {
				// Print Things
				return true;
         }
         catch
         {
				return false;
         }
      }
	}
}






