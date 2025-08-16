using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Management;
#nullable disable

namespace CobaltOS
{
    [SupportedOSPlatform("windows")]
    public static class Statistics
    {
        public static void AdvancedSystemStats()
        {

        }

        public static void SystemSpecs()
        {
            string computerName = Environment.MachineName;
            string username = Environment.UserName;
            var operatingSystem = Environment.OSVersion;
            bool is64BitOS = Environment.Is64BitOperatingSystem;
            DateTime todaysDate = DateTime.Today;

            string cpuName = "";
            int cores = 0;
            int logicalProcessers = 0;
            double ramSizeGB = 0;
            int usedSlots = 0;
            int totalSlots = 0;
            int ramSpeed = 0;
            foreach (var item in new ManagementObjectSearcher("Select Name, NumberOfCores from Win32_Processor").Get())
            {
                cpuName = Convert.ToString(item["Name"]);
                cores += int.Parse(item["NumberOfCores"].ToString());
            }
            foreach (var item in new ManagementObjectSearcher("Select NumberOfLogicalProcessors from Win32_ComputerSystem").Get())
            {
                logicalProcessers += int.Parse(item["NumberOfLogicalProcessors"].ToString());
            }
            foreach (var item in new ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem").Get())
            {
                ramSizeGB = double.Parse(item["TotalPhysicalMemory"].ToString());
                ramSizeGB = Math.Ceiling(ramSizeGB / (1024.0 * 1024.0 * 1024.0));
            }
            foreach (var item in new ManagementObjectSearcher("SELECT Speed FROM Win32_PhysicalMemory").Get())
            {
                usedSlots++;
                ramSpeed = Convert.ToInt32(item["Speed"]);
            }
            foreach (var item in new ManagementObjectSearcher("SELECT MemoryDevices FROM Win32_PhysicalMemoryArray").Get())
            {
                totalSlots += Convert.ToInt32(item["MemoryDevices"]);
            }

            StringBuilder disks = new StringBuilder();
            foreach (var item in new ManagementObjectSearcher("SELECT Index, Model FROM Win32_DiskDrive").Get())
            {
                string diskIndex = item["Index"].ToString();
                string diskModel = item["Model"].ToString();

                disks.AppendLine($"Disk: {diskIndex}");
                disks.AppendLine($"Model: {diskModel}");
                disks.AppendLine();
            }

            StringBuilder gpu = new StringBuilder();
            byte gpuIndex = 0;
            foreach (var item in new ManagementObjectSearcher("SELECT Name, AdapterRAM, DriverVersion, DriverDate FROM Win32_VideoController").Get())
            {
                string gpuName = item["Name"].ToString();
                string totalGpuMemory = item["AdapterRAM"].ToString();
                string driverVersion = item["DriverVersion"].ToString();
                string driverDate = item["DriverDate"].ToString();
                driverDate = driverDate.Substring(0, 4) + "/" +
                driverDate.Substring(4, 2) + "/" +
                driverDate.Substring(6, 2)
                ;
                disks.AppendLine();
                disks.AppendLine($"Gpu: {gpuIndex}");
                disks.AppendLine($"Name: {gpuName}");
                disks.AppendLine($"Total GPU Memory: {totalGpuMemory}");
                disks.AppendLine($"Driver Version: {driverVersion}");
                disks.AppendLine($"Driver Date: {driverDate}"); // Driver date (WMI stores as yyyymmddHHMMSS.000000+timezone)
                disks.AppendLine();
                gpuIndex++;
            }

            string specsText =
            $"""
            System Specs Script: By PizzaKing29
            -------------------------------

            PC Computer Name: {computerName}
            PC Username: {username}
            OS Version: {operatingSystem}
            64-Bit OS: {is64BitOS}
            Date: {todaysDate.ToShortDateString()}


            CPU Name: {cpuName}
            CPU Cores: {cores} cores, {logicalProcessers} threads


            Ram Size: {ramSizeGB}GB
            Slots Used: {usedSlots} of {totalSlots}
            Ram Speed: {ramSpeed} MT/s


            {disks}


            {gpu}
            """;

            // Create the system specs text file
            File.WriteAllText(Path.Combine(@$"C:\Users\{username}\Downloads", "SystemSpecs.txt"), specsText);
        }
    }
}
