using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GraphicsHandler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm frm = new MainForm();
            Application.Run(frm);
            if (frm.thread != null)
                frm.thread.Abort();
            frm.Close();
        }
    }
}