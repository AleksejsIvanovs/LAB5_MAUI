using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_MAUIDATA.Models
{
    public class House
    {
        public int Id { get; set; }

        public int YearBuilt { get; set; }

        public string Owner { get; set; }

        public double Area { get; set; }

        public int Floors { get; set; }
    }
}
