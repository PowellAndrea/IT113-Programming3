//  -----   Node Class    -----
//  andrea.powell@student.centralia.edu
//  IT-113  *   HW3: Linked List
//
//	Basic copy of class work
//
//  todo:
//		ready to test
//   ---------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powell_linkedlist
{
	class Node
	{
		private String _data;
		private Node _next;

		public Node()
      {
			_data = null;
      }

		public Node(String Data)
		{
			_data = Data;
		}

		public String Data
		{
			get { return _data; }
			set { _data = value; }
		}

		public Node Next
		{
			get { return _next; }
			set { _next = value; }
		}
	}
}
