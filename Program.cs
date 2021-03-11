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
            port exploit_main = new port();
            IntPtr task_t = new kernel_utility.kutil().task_for_pid(0x0fffff, false, System.Diagnostics.Process.GetProcessesByName("EXPLORER")[0].Id);
            new kernel_utility.kutil().LOG("pid_t -> {0}", System.Diagnostics.Process.GetProcessesByName("EXPLORER")[0].Id);
            exploit_main.bf_kernel_base();
           
        }
    }
}
