using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Runtime.InteropServices;

namespace Selenium3
{
    

    class ConsoleWindow
    {
        const int SWP_NOSIZE = 0x0001;


        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        private static IntPtr MyConsole = GetConsoleWindow();

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        public static void ConsoleAttributes()
         {
            Console.WindowWidth = 99;
            Console.WindowHeight = 75;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;

            int xpos = 2000;
            int ypos = 100;
            SetWindowPos(MyConsole, 0, xpos, ypos, 0, 0, SWP_NOSIZE);

        }


    }


}
