using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2
{
    public class Course
    {
        public int Hours { get; set; }
        public string Name { get; set; }
        public Department department { set; get; }
        public Subject subject { set; get; }
    }
}
