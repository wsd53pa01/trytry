using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaculateBMI003
{
    class Bmi
    {
        public double height { get; set; }
        public double weight { get; set; }
        public double bmi()
        {
            return (weight / ((height * height) / 10000));
        }
        public string result()
        {
            return (weight / ((height * height) / 10000)).ToString("#.##");
        }
    }
}
