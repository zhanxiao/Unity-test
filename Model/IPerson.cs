using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model 
{
    public interface IPerson
    {
        string ClassName { get; set; }
        string Name { get; set; }
        void Say();
    }
}
