using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student : IPerson
    {
        public string Name { get; set; }
        public string ClassName { get; set; }
        public void Say()
        {
            Console.WriteLine($"我是{Name}");
            Console.ReadLine();
        }
    }
}
