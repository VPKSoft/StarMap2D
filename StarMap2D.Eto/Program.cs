using Eto.Drawing;
using Eto.Forms;
using System;

namespace StarMap2D.Eto
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            new Application().Run(new MainForm());
            //new Application(Eto.Platform.Detect).Run(new MainForm());
        }
    }
}
