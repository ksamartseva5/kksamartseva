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
        public double LowLevel { get; set; }
        public double HighLevel { get; set; }
        public ParameterInfo[] GetDecription()
        {
            return new[]
{
                new ParameterInfo()
                {
                    Name = "Нижний уровень",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 0,
                    Increment = 0.01
                },
                new ParameterInfo()
                {
                    Name = "Верхний уровень",
                    MinValue = 0,
                    MaxValue = 1,
                    DefaultValue = 1,
                    Increment = 0.01
                }
            };
        }

        public void SetValues(double[] values)
        {
            if (values[0] < values[1])
            {
                LowLevel = values[0];
                HighLevel = values[1];
            }
            else
                throw new ArgumentException("Неверное значение границ каналов!", "Нижняя граница должна быть меньше верхней!");
        }
    }
}
