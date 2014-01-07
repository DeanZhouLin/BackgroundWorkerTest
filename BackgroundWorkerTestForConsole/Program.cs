using System;
using System.ComponentModel;
using BackgroundWorkerExtensionLib;

namespace BackgroundWorkerTestForConsole
{
    class Program
    {
        private static readonly BackgroundWorker bw = BackgroundWorkerExtension.InitNewBackgroundWorker(null,null,null);

        static void Main(string[] args)
        {
            bw.RunWorkerAsyncExt(null); 

            Console.ReadLine();

            bw.CancelAsyncExt();

            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
