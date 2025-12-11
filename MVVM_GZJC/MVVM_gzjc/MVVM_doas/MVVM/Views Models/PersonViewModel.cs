using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_bbhdzp.MVVM.Models;

namespace MVVM_bbhdzp.MVVM.Views_Models
{
    internal class PersonViewModel
    {
        public Person Person { get; set; }
        
        public PersonViewModel()
        {
            Person = new Person
            {
                Name = "Pepito",
                Age = 0,
                Married = true,
                Birthday = new DateTime(2002,7,2),
                Weight = 70,
                LunchTime = new TimeSpan(14,0,0)
            };

        }
    }
}
