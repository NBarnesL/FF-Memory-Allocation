using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs471_project2
{
	public class Process : IComparable<Process>
	{
		private double id;
		private double priority;
		private double burstTime;
		private bool completed = false;
		private bool stopped = false;
		private bool started = false;
		private String name;
		private double startTime;
		private double stopTime;

		private int size;

		private double elapsedTime;



		public Process(double _id, String _name, int _size)
		{
			id = _id;
			name = _name;
			size = _size;
			stopTime = 0;
			

			started = false;
			stopped = false;
		}

		public Process(Process p)
		{
			id = p.id;
			name = p.name;
			priority = p.priority;
			burstTime = p.burstTime;
			//---------------------
			startTime = p.startTime;
			size = p.size;
		}

		public String toString()
		{
			String d = "\t";
			String s = "id\tname\tpriority \tburst Time  \n" +
					id + d + name + d + Convert.ToInt32(priority) + d + burstTime + d + "\n";
			return s;
		}
		public double getID()
		{
			return id;
		}

		public int getSize()
		{
			return size;

		}

		public String getName()
		{
			return name;
		}

		public double getPriority()
		{
			return priority;
		}

		public double getBurstTime()
		{
			return burstTime;
		}

		public double getStartTime()
		{
			return startTime / 10000000;
		}

		public double getElapsedTime()
		{
			elapsedTime = DateTime.Now.Ticks / 10000000 - startTime;
			return elapsedTime;
		}

		//Function to simiulate process start
		public void start()
		{
			startTime = DateTime.Now.Ticks / 10000000;
			started = true;
		}


		//Function to simulate process stop and track the time
		public void stop()
		{

			stopped = true;
			stopTime = DateTime.Now.Ticks / 10000000;


		}

		public void terminate()
		{
			stopped = true;
			completed = true;
		}

		public bool getCompleted()
		{
			if (elapsedTime >= burstTime)
			{
				completed = true;
			}

			if (completed)
				return true;
			else
				return false;

		}





		public int CompareTo(Process p)
		{
			//bigger priority number, lower priority
			if (this.getPriority() > p.getPriority())
			{
				return 1;
			}

			if (this.getPriority() < p.getPriority())
			{
				return -1;
			}


			return -1;
		}

	}
}
