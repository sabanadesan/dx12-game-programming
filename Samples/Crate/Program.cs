﻿using System.Diagnostics;

namespace DX12GameProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (D3DApp app = new CrateApp(Process.GetCurrentProcess().Handle))
            {
                app.Initialize();
                app.Run();
            }
        }
    }
}