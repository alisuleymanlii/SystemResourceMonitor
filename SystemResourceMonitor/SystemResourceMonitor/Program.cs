using System.Diagnostics;
using System.Threading;
using System;

var cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
var ram = new PerformanceCounter("Memory", "Available MBytes");
var disk = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");

while (true)
{
            Console.Clear();

            float cpuValue = cpu.NextValue();
            Console.Write("CPU: ");
            if (cpuValue > 80) Console.ForegroundColor = ConsoleColor.Red;
            else if (cpuValue > 50) Console.ForegroundColor = ConsoleColor.Yellow;
            else Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(cpuValue.ToString("0.0") + " %");
            Console.ResetColor();

            float ramValue = ram.NextValue();
            Console.Write("RAM: ");
            if (ramValue < 2000) Console.ForegroundColor = ConsoleColor.Red; 
            else if (ramValue < 4000) Console.ForegroundColor = ConsoleColor.Yellow; 
            else Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ramValue.ToString("0") + " MB boş");
            Console.ResetColor();

            float diskValue = disk.NextValue();
            Console.Write("Disk: ");
            if (diskValue > 80) Console.ForegroundColor = ConsoleColor.Red;
            else if (diskValue > 50) Console.ForegroundColor = ConsoleColor.Yellow;
            else Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(diskValue.ToString("0.0") + " %");
            Console.ResetColor();


            Thread.Sleep(1000);
}