using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Troll
{
    class Draw
    {
        public static void String(string s, int x, int y, Color color, int size)
        {
            IntPtr dc = WinAPI.GetDC(IntPtr.Zero);
            Brush brush = new SolidBrush(color);
            Font font = new Font("Arial", size);
            using (Graphics g = Graphics.FromHdc(dc))
            {
                g.DrawString(s, font, brush, new Point(x, y));
            }
            WinAPI.ReleaseDC(IntPtr.Zero, dc);
        }
    }
}
