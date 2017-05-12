using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dougs_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 20, 3, 5, 1, 34 };
            List<int> list2 = new List<int> { 1, 6, 5, 6, 8, 2, 8 };
            StringBuilder addedList = new StringBuilder();
            int len1 = 0;
            int len2 = 0;
            List<int> greaterList = new List<int> { };

            if (list1.Count() > list2.Count())
                { len1 = list2.Count();
                len2 = list1.Count();
                greaterList = list1;
            }
            else
                { len1 = list1.Count();
                len2 = list2.Count();
                greaterList = list2;
            }

            for (int i = 0; i < len1; i++ )
                { addedList.Append(list1[i] + list2[i] + " "); }

            for (int i = len1; i < len2; i++)
                { addedList.Append(greaterList[i] + " "); }


            Console.WriteLine(addedList);
            Console.ReadLine();
        }
    }
}
