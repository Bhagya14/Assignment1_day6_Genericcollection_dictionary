using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            names.Add(100, "XYZ");
            names.Add(101, "ABCD");
            foreach(KeyValuePair<int,string> kv in names)
            {
                Console.WriteLine("Key :" + kv.Key + " " + "Value :" + kv.Value);
            }
            foreach(int key in names.Keys)
            {
                Console.WriteLine("Only Key :" + key);
            }
            foreach(string value in names.Values)
            {
                Console.WriteLine("Only Value :" + value);
            }
            Console.WriteLine(names.Count);
            string s1 = names[100];
            Console.WriteLine(s1);
            if(names.ContainsKey(100))
            {
                Console.WriteLine(names[100]);
            }


            /*
            List<int> marks = new List<int>();
            marks.Add(100);
            marks.Add(200);
            marks.Add(300);
            foreach(var m in marks)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine(marks.Count);
            bool status = marks.Contains(100);
            int x = marks[1];
            Console.WriteLine(x);
            marks.Remove(200);
            foreach (var m in marks)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine(marks.Count);
            x = marks[1];
            Console.WriteLine(x);
            */

            /*
            Test obj = new Test();
            int x = obj.GetData<int>(200);
            Console.WriteLine(x);
            double d = obj.GetData<double>(22.22);
            Console.WriteLine(d);
            string str = obj.GetData<string>("Hello");
            Console.WriteLine(str);
            */
            Console.ReadLine();
        }
    }
}
