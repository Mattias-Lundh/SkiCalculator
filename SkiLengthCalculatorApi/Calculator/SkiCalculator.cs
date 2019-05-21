using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiLengthCalculatorApi.Calculator
{
    public class SkiCalculator : ISkiCalculator
    {
        public SkiRecommendation CalculateRecomendation(CalculatorParameters calcparams)
        {
            int recomendation = calcparams.Height;
            if (calcparams.Age > 4)
                if (calcparams.Style == SkiStyle.Classic) { 
                    recomendation += 20;
                    recomendation = Math.Min(recomendation, 207);
                }
                else
                    recomendation += 10;
            return new SkiRecommendation(recomendation);
        }
    }


}
