using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_Control
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static Mutex singleInstanceMutex;

        [STAThread]
        static void Main()
        {
            try
            {
                string mutexName = String.Format("Local\\{0}", ((GuidAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), true)[0]).Value);
                singleInstanceMutex = new Mutex(true, mutexName);

                if (singleInstanceMutex.WaitOne(50, true))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    ApplicationContext applicationContext = new VolumeControlContext();
                    Application.Run(applicationContext);

                    singleInstanceMutex.ReleaseMutex();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(String.Format("Uncaught exception: {0}", ex.Message), Assembly.GetExecutingAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
