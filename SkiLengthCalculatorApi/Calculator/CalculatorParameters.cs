using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiLengthCalculatorApi.Calculator
{
    public class CalculatorParameters
    {
        public CalculatorParameters(SkiStyle style, int age, int height)
        {
            Style = style;
            Age = age;
            Height = height;
        }

        public SkiStyle Style { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
    }
}
