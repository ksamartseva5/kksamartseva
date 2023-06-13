using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class RangeIncreacsingParameters : IParameters
    {
        [ParameterInfo(Name = "Нижний уровень",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 0,
                    Increment = 0.01)]
        public double LowLevel { get; set; }

        [ParameterInfo(Name = "Верхний уровень",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 0,
                    Increment = 0.01)]

        public double HighLevel { get; set; }
    }
}
