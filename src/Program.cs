using System;

namespace ManoMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            Computer c = new Computer();
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            Logger.End();
        }
    }
}
