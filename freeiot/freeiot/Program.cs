using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace freeiot
{
    class Program
    {
        static void Main(string[] args)
        {
            Double CPUtprt = 0;

            System.Management.ManagementObjectSearcher mos = new System.Management.ManagementObjectSearcher("Select * From Win32_Processor");

            foreach (System.Management.ManagementObject mo in mos.Get())

            {
                Console.WriteLine(mo["L2CacheSize"]);
                Console.WriteLine(mo["Manufacturer"]);
                Console.WriteLine(mo["MaxClockSpeed"]);
                Console.WriteLine(mo["ProcessorId"]);
                CPUtprt = Convert.ToDouble(Convert.ToDouble(mo["CurrentTemperature"].ToString()) - 2732) / 10;
                Console.WriteLine("CPU 温度 : " + CPUtprt.ToString() + " °C");
            }

        }
    }
}
