using Nager.TextValidation.Contract;
using System.Drawing;

namespace Nager.TextValidation.DrawKeyboard
{
    public class DrawEngine
    {
        public void DrawKeyboard(IKeyboard keyboard)
        {
            var keys = keyboard.GetCharPositions();

            using (var bitmap = new Bitmap(1000, 200))
            {
                using (var graphic = Graphics.FromImage(bitmap))
                {
                    foreach (var key in keys)
                    {
                        var x = (int)(key.Value.X * 35);
                        var y = 200 - (int)(key.Value.Y * 35);

                        graphic.FillRectangle(Brushes.Orange, new Rectangle(x, y, 30, 30));
                        graphic.DrawString(key.Key.ToString(), new Font(FontFamily.GenericSerif, 10), new SolidBrush(Color.Black), x, y);
                    }

                    bitmap.Save($"{keyboard.GetType()}.bmp");
                }
            }
        }
    }
}
