using System;
using System.ComponentModel;
using BackgroundWorkerExtensionLib;

namespace BackgroundWorkerTestForConsole
{
    class Program
    {
        static void Main()
        {
            BackgroundWorker bw = BackgroundWorkerExtension.InitNewBackgroundWorker();
            bw.RunWorkerAsyncExt(); 
            Console.ReadLine();
        }
    }
}
