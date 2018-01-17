using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSDL_GLClient.Operator
{
    public static class Tools
    {
        public static bool StartProcess(string fileName, string[] args)
        {
            try
            {
                string s = "";
                foreach (string arg in args)
                {
                    s = s +" "+ arg;
                }
                s = s.Trim();
                Process myprocess = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo(fileName, s);
                myprocess.StartInfo = startInfo;
                myprocess.StartInfo.UseShellExecute = false;
                myprocess.Start();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
