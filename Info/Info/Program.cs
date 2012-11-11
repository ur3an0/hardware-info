using System;
using System.Management;

namespace ConsoleApplication1
{
    class Class1
    {
        static void Main(string[] args)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * from Win32_DiskDrive");

            foreach (ManagementObject cdrom in searcher.Get())
            {
                Console.WriteLine("Valor: {0}\n",
                              cdrom.GetPropertyValue("TotalHeads"));
            }
            Console.Read();
        }
    }
}