using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace ConsoleApp7
{
    class Program
    {
        internal struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        //Ich hab so ungefähr null Ahnung was das meiste hier bedeutet
        //aber es war nach drei Tagen, das erste, das funktioniert
        //verfickte scheiße, das ist nur um die Fenster zu bewegen und auf die 
        //richtige größe zu bringen
        //wasn bullshit

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        internal static extern bool GetWindowRect(IntPtr hWnd, ref RECT rect);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        internal static extern void MoveWindow(IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);


        static void Main(string[] args)
        {
            Cmd2();
            Thread.Sleep(200);
            Cmd1();
            Thread.Sleep(200);
            Cmd3();
            Thread.Sleep(200);
            Cmd4();
        }
        static void Cmd1()
        {
            System.Diagnostics.Process.Start("cmd.exe", "/K cd C:/ & color c & tree ");
            IntPtr id;
            RECT Rect = new RECT();
            Thread.Sleep(200);
            id = GetForegroundWindow();
            Random myRandom = new Random();
            GetWindowRect(id, ref Rect);
            MoveWindow(id, 490, 0, 600, 800, true);
        }
        static void Cmd2()
        {
            System.Diagnostics.Process.Start("cmd.exe", "/K cd C:/ & color c & dir/s ");
            IntPtr id;
            RECT Rect = new RECT();
            Thread.Sleep(200);
            id = GetForegroundWindow();
            Random myRandom = new Random();
            GetWindowRect(id, ref Rect);
            MoveWindow(id, 0, 0, 500, 800, true);
        }

        static void Cmd3()
        {
            System.Diagnostics.Process.Start("cmd.exe", "/K cd C:/ & color a & dir/s ");
            IntPtr id;
            RECT Rect = new RECT();
            Thread.Sleep(200);
            id = GetForegroundWindow();
            Random myRandom = new Random();
            GetWindowRect(id, ref Rect);
            MoveWindow(id, 1050, 0, 500, 800, true);
        }

        static void Cmd4()
        {
            System.Diagnostics.Process.Start("cmd.exe", "/K cd C:/ & color a & ping www.nsa.com ");
            IntPtr id;
            RECT Rect = new RECT();
            Thread.Sleep(200);
            id = GetForegroundWindow();
            Random myRandom = new Random();
            GetWindowRect(id, ref Rect);
            MoveWindow(id, 490, 300, 600, 200, true);
        }
    }
}
