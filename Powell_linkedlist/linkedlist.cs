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
//		The first item in the list is not being deleted
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
				return NewThing;
			}

			Node CurrentNode = Head;

			while (CurrentNode != null)
			{
				//Find the last thing and append this new thing.
				if (CurrentNode.Next == null)
				{
					CurrentNode.Next = NewThing;
					return Head;
				}
				else
				{
					CurrentNode = CurrentNode.Next;
				}
			}
			return Head;
		}

		//  Contains: Returns a node with a matching item; if no match, return null
		public Node Contains(Node nodeHead, String strTarget)
		{
			if (nodeHead == null || strTarget == null) { return null; }

			if (nodeHead.Data == strTarget)
			{ 
				return nodeHead;
			}

			Node Current = nodeHead;
			while (Current.Next != null)
			{
				Current = Current.Next;
				if (Current.Data == strTarget) { return Current; }
			}
			return null;
		}

		//  Removes node containing the item and links the two adjacent nodes together
		public Boolean Delete(Node Head, Node nodeTarget)
		{
			if ((Head != null) && (nodeTarget != null))
			{
				if (Head == nodeTarget) 
				{
					Node newHead = nodeTarget.Next;
					Head = newHead;
					return true;
				}
				
				Node nodeCurrent = Head;

				while (nodeCurrent.Next != null)
				{
					if (nodeCurrent.Next == nodeTarget)
					{
						//  This will delete the first instance found.  If there were additional matches, they will be ignored.
						nodeCurrent.Next = nodeTarget.Next;
						return true;
					}
					nodeCurrent = nodeCurrent.Next;
				}
			}
			return false;
		}
		// Prints the entire list front to back.Breaking encapsulation here is permitted
		public void PrintAllNodes(Node Head)
		{
			if (Head == null)
			{
				Console.WriteLine("The list is empty.  There are no things.");
			}
			else
			{
				Node CurrentNode = Head;

				while (CurrentNode != null)
				{
					Console.WriteLine(CurrentNode.Data);
					CurrentNode = CurrentNode.Next;
				}
			}
		}
	}
}