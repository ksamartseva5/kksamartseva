using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEnhancer
{
    public class RangeIncreasingFilter : PixelFilter
    {
        public override ParameterInfo[] GetParametersInfo()
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

        public override Pixel ProcessPixel(Pixel pixel, double[] parameters)
        {
            if (parameters[0] >= parameters[1])
            {
                MessageBox.Show("Неверное значение границ каналов!", "Нижняя граница должна быть меньше верхней!");
                return pixel;
            }
            else
                return new Pixel(IncreaseRangeOfBrightness(pixel.R, parameters[0], parameters[1]),
                    IncreaseRangeOfBrightness(pixel.G, parameters[0], parameters[1]),
                    IncreaseRangeOfBrightness(pixel.B, parameters[0], parameters[1]));
        }

        public override string ToString()
        {
            return "Расширение диапазона";
        }
        public double IncreaseRangeOfBrightness(double brightness,double l1, double l2)
        {
            double new_brigthness;
            new_brigthness = (brightness - l1) / (l2 - l1);
            if (new_brigthness < 0)
                return 0;
            if (new_brigthness > 1)
                return 1;
            else
                return new_brigthness;
        }
    }
}
