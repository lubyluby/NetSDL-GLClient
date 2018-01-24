using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picking
{
    public class BaseForm:Form
    {
        protected override void WndProc(ref Message msg)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;

            if (msg.Msg == WM_SYSCOMMAND && ((int)msg.WParam == SC_CLOSE))
            {
                Application.ExitThread();
                //把前窗体进程也退出
                Process[] pr = System.Diagnostics.Process.GetProcessesByName("NetSDL-GLClient");
                foreach (Process p in pr)
                {
                    p.Kill();
                }
                return;
            }
            base.WndProc(ref msg);
        }
    }
}
