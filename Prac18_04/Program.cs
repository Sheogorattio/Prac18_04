using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prac18_04
{
    internal class Program
    {
        public static void ToStringThread(object obj)
        {

            List<int> list = new List<int>((List<int>)obj);
            foreach (var i in list)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            for(int i=0; i<10; i++)
                list.Add(rnd.Next(0,100));
            Thread th = new Thread(new ParameterizedThreadStart(ToStringThread));
            th.Start(list);
            Console.Read();
        }
    }
}
