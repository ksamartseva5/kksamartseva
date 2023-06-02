using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PhotoEnhancer
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();

            mainForm.AddFilter(new PixelFilter<LighteningParameters>(
                "Осветление/затемнение",
                (pixel, parameters) => pixel * parameters.Coefficient));
            
            mainForm.AddFilter(new PixelFilter<EmptyParameters>(
                "Оттенки серого",
                (pixel, parameters) =>
                {
                    var lightness = 0.3 * pixel.R + 0.6 * pixel.G + 0.1 * pixel.B;
                    return new Pixel(lightness, lightness, lightness);
                }));

            mainForm.AddFilter(new PixelFilter<RangeIncreacsingParameters>(
                "Расширение диапазона",
                (pixel, parameters) =>
                {
                    double IncreaseRangeOfBrightness(double brightness, double l1, double l2)
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
                    return new Pixel(IncreaseRangeOfBrightness(pixel.R, parameters.LowLevel, parameters.HighLevel),
                   IncreaseRangeOfBrightness(pixel.G, parameters.LowLevel, parameters.HighLevel),
                   IncreaseRangeOfBrightness(pixel.B, parameters.LowLevel, parameters.HighLevel));
                }));

            mainForm.AddFilter(new TransformFilter(
                "Отражение по горизонтали",
                size => size,
                (point, size) => new Point(size.Width - point.X - 1, point.Y)
                ));
            
            mainForm.AddFilter(new TransformFilter(
                "Отражение по вертикали",
                size => size,
                (point, size) => new Point(point.X,size.Height - point.Y - 1)
                ));

            mainForm.AddFilter(new TransformFilter(
                "Поворот на 90° против ч. с.",
                size => new Size(size.Height, size.Width),
                (point, size) => new Point(size.Width - point.Y - 1, point.X)
                ));

            mainForm.AddFilter(new TransformFilter<RotationParameters>(
                "Поворот на произвольный угол",
                new RotateTransformer()
                ));

            Application.Run(mainForm);
        }
    }
}
