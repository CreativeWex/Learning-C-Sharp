using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOPLab13Cs
{
    class BuildList
    {
        List<STUDENT> classmate = new List<STUDENT>();
        public const int size = 5;
        int listSize;

        public bool checkSurname(string surname)
        {
            int error = 0;

            if (surname == null)
                error++;
            for (int i = 0; i < surname.Length; i++)
                if (Char.IsDigit(surname[i]))
                    error++;
            if (error == 0)
                return false;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error in surname");
                Console.ResetColor();
                return true;
            }
        }

        public BuildList()
        {
            string surname;
            int group;
            string marks = "";
            int[] progress = new int[size];
            StreamReader input = new StreamReader("input.txt");

            while (!(input.EndOfStream))
            {
                surname = input.ReadLine();
                if (checkSurname(surname))
                    break;

                if(!Int32.TryParse(input.ReadLine(), out group))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error in surname");
                    Console.ResetColor();
                }

                marks = input.ReadLine();
                string[] marksArray = marks.Split(' ');
                for (int i = 0; i < marksArray.Length; i++)
                    Int32.TryParse(marksArray[i], out progress[i]);

                int[] copyprg = new int[progress.Length];
                Array.Copy(progress, copyprg, progress.Length);
                classmate.Add(new STUDENT(surname, group, copyprg));
            }
            listSize = classmate.Count;
        }

        public void Print()
        {
            for (int i = 0; i < classmate.Count; i++)
                classmate[i].Display();
        }
        public double CountAverage(int[] a)
        {
            double avg = 0;

            for (int i = 0; i < size; i++)
                avg += a[i];
            return (avg / size);
        }
        public void ShowAverage()
        {
            int flag = 0;
            for (int i = 0; i < listSize; i++)
            {
                if (CountAverage(classmate[i].Progress) > 4)
                {
                    Console.WriteLine($"| {classmate[i].surname,10} | {classmate[i].group,1} group |");
                    flag++;
                }
            }
            if (flag == 0)
                Console.WriteLine("No such students");
        }
        public void Sort()
        {
            STUDENT insert;
            for (int next = 1; next < listSize; next++)
            {
                insert = classmate[next];
                int moveItem = next;
                while (moveItem > 0 && classmate[moveItem - 1].group > insert.group)
                    moveItem--;
                classmate.RemoveAt(next);
                classmate.Insert(moveItem, insert);
            }
        }
    }//класс
}