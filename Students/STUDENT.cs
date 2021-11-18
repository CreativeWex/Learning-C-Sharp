using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab13Cs
{
	class STUDENT
	{
		public string surname;
		public int group;
		int[] progress = new int[5];
        public int[] Progress
        {
            get { return progress; }
        }
		public STUDENT(string surname, int group, int[] progress)
		{
			this.surname = surname;
			this.group = group;
			this.progress = progress;
		}
		public void Display()
		{
			Console.Write($"| {surname, 10} | {group, 1} group | marks are: ");
			for (int i = 0; i < 5; i++)
				Console.Write($"{progress[i]} ");
			Console.Write("|");
			Console.WriteLine();
		}
	}
}
