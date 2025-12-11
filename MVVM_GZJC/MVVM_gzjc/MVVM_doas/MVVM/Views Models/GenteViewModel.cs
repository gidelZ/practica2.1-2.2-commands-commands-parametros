using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_bbhdzp.MVVM.Views_Models
{
    internal class GenteViewModel
    {
        public List<string> Gente { get; set; }
        public GenteViewModel()
        {
            Gente = new List<string>
            {
                "Juancho",
                "SalvaTrucha",
                "Mario",
                "Mariana",
                "Chon"

            };
        }
    }
}
