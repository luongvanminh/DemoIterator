using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoFor
{
    public interface IIterator
    {
        // Reset to first element
        void First();
        // Get next element
        int Next();
        // End of collection check
        bool IsCollectionEnds();
        // Retrieve Current Item
        int CurrentItem();

        void ForEachItem(Action<int> foo);
    }

    public class IntIterator : IIterator
    {
        private LinkedList<int> IntSubjects;
        private int position;

        public IntIterator(LinkedList<int> intSubjects)
        {
            this.IntSubjects = intSubjects;
            position = 0;
        }

        public int CurrentItem()
        {
            return IntSubjects.ElementAt<int>(position);
        }

        public void First()
        {
            position = 0;
        }

        public void ForEachItem(Action<int> foo)
        {
            int i = 0;
            while (i < IntSubjects.Count)
            {
                foo(IntSubjects.ElementAt<int>(i));
                i++;
            }
        }

        public bool IsCollectionEnds()
        {
            if(position >= IntSubjects.Count) {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Next()
        {
            position++;
            if (position < IntSubjects.Count) 
                return IntSubjects.ElementAt<int>(position);
            return -1;
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vui long nhap vao n:");
            int n = Convert.ToInt32(Console.ReadLine());

            LinkedList<int> listN = new LinkedList<int>();
            for (int j = 1; j <= n; j++)
            {
                listN.AddLast(j);
            }

            //int i = 1;
            //while (i <= n)
            //{
            //    if (i % 2 == 1)
            //        Console.Write($"{i} ");
            //    i++;
            //}

            IntIterator intIterator = new IntIterator(listN);

            while (!intIterator.IsCollectionEnds())
            {
                int mIterator = intIterator.CurrentItem();
                if (mIterator % 2 == 1)
                    Console.Write($"{mIterator} ");
                intIterator.Next();
            }

            intIterator.ForEachItem(Console.WriteLine);
        }
    }
}
