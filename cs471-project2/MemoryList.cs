using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs471_project2
{
	class MemoryList
	{
		private LinkedList<Block> BlockList = new LinkedList<Block>();


		//if the free space is used and the top is empty and the bottom is empty
		public void setupOption1()
		{
			BlockList.Clear();
			BlockList.AddLast(new Block(3));
			BlockList.AddLast(new Block(7, new Process(500, "gaming", 7)));
			BlockList.AddLast(new Block(3));

		}

		//if the top is full and the bottom is empty
		public void setupOption2()
		{
			BlockList.Clear();
			BlockList.AddLast(new Block(3, new Process(500, "gaming", 3)));
			BlockList.AddLast(new Block(7));
			BlockList.AddLast(new Block(3));
		}

		//if the top is empty and the bottom is full
		public void setupOption3()
		{
			BlockList.Clear();
			BlockList.AddLast(new Block(3));
			BlockList.AddLast(new Block(7));
			BlockList.AddLast(new Block(3, new Process(500, "gaming", 3)));
		}

		//if all spaces are full
		public void setupOption4()
		{
			BlockList.Clear();
			BlockList.AddLast(new Block(3, new Process(500, "gaming", 3)));
			BlockList.AddLast(new Block(3, new Process(501, "gaming", 7)));
			BlockList.AddLast(new Block(3, new Process(502, "gaming", 3)));

		}


		public bool AddProcesstoBlock(Process _newProcessObject)
		{
			bool a = false;
			LinkedListNode<Block> node = BlockList.First;
			while (node != null)
			{
				if (_newProcessObject.getSize() <= node.Value.getSize() && !node.Value.isAllocated())
				{

					a = true;
					node.Value.reallocateSpace(_newProcessObject.getSize());

					BlockList.AddAfter(node, new Block(_newProcessObject.getSize(), _newProcessObject));
					
					if (node.Value.getSize() == 0)
					{
						BlockList.Remove(node);
					}


					break;
				}
				node = node.Next;
			}

			return a;
		}


		public bool RemovefromBlockList(int _id)
		{
			bool a = false;
			LinkedListNode<Block> node = BlockList.First;

			while (node != null)
			{
				if (_id == node.Value.getContainer().getID())
				{
					a = true;
					node.Value.Remove();
					break;
				}
				node = node.Next;
			}

			return a;
		}



		public String getBlockList()
		{
			string gaming = "Address\tSpace\tOccupied\tProcess ID\n";
			int i = 0;

			foreach (Block str in BlockList)
			{
				gaming += i.ToString();
				gaming += "\t" + str.getSize();
				gaming += "\t" + str.isAllocated().ToString();
				gaming += "\t" + str.getContainer().getID().ToString() + "\n";
				i++;
			}

			return gaming;
		}

		// Moves all occurrences of given key to
		// end of linked list.
		public void garbageCollection()
		{
			bool needRestart = true;
			LinkedListNode<Block> actualNode = BlockList.First; //node Im working with    
			LinkedListNode<Block> node = BlockList.First;
			Block temp;
			while (node !=null &&needRestart == true)
            {
				actualNode = BlockList.First;
				needRestart = false;
				while (actualNode.Next != null)
				{
					if (actualNode.Value.isAllocated() == false)
					{
						//swap the data
						temp = actualNode.Value;
						actualNode.Value = actualNode.Next.Value;
						actualNode.Next.Value = temp;
						needRestart = true;

					}
					actualNode = actualNode.Next;
					
				}
				node = node.Next;
			}

			int sumOfFreeSpace = 0;
			int numOfFree = 0;
			node = BlockList.First;
			while (node != null)
			{
				if (node.Value.isAllocated() == false)
				{
					sumOfFreeSpace += node.Value.getSize();
					numOfFree++;
					//BlockList.Remove(node);
				}
				node = node.Next;
			}
			for (int i = 0; i<numOfFree; i++)
            {
				BlockList.RemoveLast();
            }

			if (sumOfFreeSpace > 0)
			{
				BlockList.AddLast(new Block(sumOfFreeSpace));
			}

		}


		public class Block
		{

			private bool a;
			private int size;
			Process container;
			Process blankProcess;


			public Block(int _size)
			{
				size = _size;
				a = false;

				container = new Process(0, "", size);
				blankProcess = new Process(0, "", size);
			}

			public Block(int _size, Process _process)
			{
				size = _size;
				container = _process;
				a = true;
			}
			public int getSize()
			{
				return size;
			}
			public Process getContainer()
			{
				return container;
			}

			public void reallocateSpace(int _size)
			{
				size = size - _size;
			}

			public bool isAllocated()
			{
				return a;
			}


			public void Remove()
			{
				container = new Process(0, "", size);
				a = false;
			}

		}

	}
}