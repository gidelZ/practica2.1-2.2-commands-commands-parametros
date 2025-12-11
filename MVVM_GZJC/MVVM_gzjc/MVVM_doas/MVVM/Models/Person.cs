using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_doas.MVVM.Models
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Married { get; set; }
        public DateTime Birthday { get; set; }

        public int Weight { get; set; }

        public TimeSpan LunchTime { get; set; }
    }
}
