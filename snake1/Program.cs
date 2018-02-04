using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1= new Point(1,3,'*');

            p1.Drow();

            Point p2 = new Point(4,5,'#');

            p2.Drow();

            Point p3 = new Point(7, 10, '&');
            Point p4 = new Point(8, 11, '(');
            Point p5 = new Point(9, 12, ')');
            Point p6 = new Point(10, 13, '%');

            List<Point> newpList = new List<Point>();
            newpList.Add(p3);
            newpList.Add(p4);
            newpList.Add(p5);
            newpList.Add(p6);

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);



            Console.ReadLine();
        }
    }
}
