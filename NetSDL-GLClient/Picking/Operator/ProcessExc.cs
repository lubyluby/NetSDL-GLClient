using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Picking
{
    public static class ProcessExc
    {
        [DllImport("user32.dll", EntryPoint = "ShowWindow", SetLastError = true)]
        static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", EntryPoint = "ShowWindowAsync", SetLastError = true)]
         public static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);

        /// <summary>
        /// 根据窗体名称显示窗体
        /// </summary>
        /// <param name="title"></param>
        public static void ShowForm(string title)
        {
            IntPtr mainHandle = FindWindow(null, title);
            //1默认2最小化3最大化
            ShowWindowAsync(mainHandle, 3);
        }

        public static void CloseForm(string title)
        {
            IntPtr mainHandle = FindWindow(null, title);
            //0隐藏1显示
            ShowWindow(mainHandle, 0);
        }

        
       
    }
}
