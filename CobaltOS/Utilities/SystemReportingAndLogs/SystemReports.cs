using System.Text;
using System.Runtime.Versioning;
using System.Management;
using System.Globalization;
#nullable disable

namespace CobaltOS
{
    [SupportedOSPlatform("windows")]
    public static class SystemReports
    {
        public static void SystemSpecs()
        {
            string computerName = Environment.MachineName;
            string username = Environment.UserName;
            var operatingSystemVersion = Environment.OSVersion;
            bool is64BitOS = Environment.Is64BitOperatingSystem;
            bool isLaptop = false;
            DateTime todaysDate = DateTime.Today;
            Version version = operatingSystemVersion.Version;

            string operatingSystem = "";
            if (version.Build >= 10240 && version.Build <= 19045)
            {
                operatingSystem = "Windows 10";
            }
            else if (version.Build >= 22000 && version.Build <= 26100)
            {
                operatingSystem = "Windows 11";
            }

            string cpuName = "";
            int cores = 0;
            string lastBootupTime = "";
            int logicalProcessers = 0;
            double clockSpeed = 0;
            double ramSizeGB = 0;
            int usedSlots = 0;
            int totalSlots = 0;
            int ramSpeed = 0;
            DateTime timeNow = DateTime.Now;
            TimeSpan time = new TimeSpan();

            foreach (var item in new ManagementObjectSearcher("Select LastBootUpTime from Win32_OperatingSystem").Get())
            {
                lastBootupTime = Convert.ToString(item["LastBootUpTime"]);
                lastBootupTime = lastBootupTime.Substring(0, 14);
                time = timeNow - DateTime.ParseExact(lastBootupTime, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            }
            try // checks if the battery percentage exists, if it does then this is a laptop, if theres an error it will be false
            {
                foreach (var item in new ManagementObjectSearcher("Select EstimatedChargeRemaining from Win32_Battery").Get())
                {
                    int batteryPercentage = 0;
                    batteryPercentage = Convert.ToInt32(item["EstimatedChargeRemaining"]);
                    if (batteryPercentage > 0)
                    {
                        isLaptop = true;
                    }
                    else
                    {
                        isLaptop = false;
                    }
                }
            }
            catch (Exception)
            {
                isLaptop = false;
            }
            foreach (var item in new ManagementObjectSearcher("Select Name, NumberOfCores, MaxClockSpeed from Win32_Processor").Get())
            {
                cpuName = Convert.ToString(item["Name"]);
                cores += int.Parse(item["NumberOfCores"].ToString());
                clockSpeed = Math.Round(Convert.ToDouble(item["MaxClockSpeed"]) / 1000.0, 1);
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
            foreach (var item in new ManagementObjectSearcher("SELECT Index, Model, InterfaceType, Size FROM Win32_DiskDrive").Get())
            {
                string diskIndex = item["Index"].ToString();
                string diskModel = item["Model"].ToString();
                string diskType = item["InterfaceType"].ToString();
                double diskSize = Math.Round(Convert.ToDouble(item["Size"]) / 1e9);
                
                disks.AppendLine($"Disk: {diskIndex}");
                disks.AppendLine($"Model: {diskModel}");
                disks.AppendLine($"Size: {diskSize} GB");
                disks.AppendLine($"Type: {diskType}");
                disks.AppendLine();
            }

            StringBuilder gpu = new StringBuilder();
            byte gpuIndex = 0;
            foreach (var item in new ManagementObjectSearcher("SELECT Name, DriverVersion, DriverDate FROM Win32_VideoController").Get())
            {
                string gpuName = item["Name"].ToString();
                string driverVersion = item["DriverVersion"].ToString();
                string driverDate = item["DriverDate"].ToString();
                driverDate = driverDate.Substring(0, 4) + "/" +
                driverDate.Substring(4, 2) + "/" +
                driverDate.Substring(6, 2)
                ;
                gpu.AppendLine();
                gpu.AppendLine($"Gpu: {gpuIndex}");
                gpu.AppendLine($"Name: {gpuName}");
                gpu.AppendLine($"Driver Version: {driverVersion}");
                gpu.AppendLine($"Driver Date: {driverDate}");
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
            Is Laptop: {isLaptop}
            Date: {todaysDate.ToShortDateString()}


            CPU Name: {cpuName}
            CPU Cores: {cores} cores, {logicalProcessers} threads
            CPU Base Clock Speed: {clockSpeed:F2} GHz
            CPU Uptime: {time.Days} Days, {time.Hours} Hours, {time.Minutes} Minutes, {time.Seconds} Seconds


            Ram Size: {ramSizeGB}GB
            Slots Used: {usedSlots} of {totalSlots}
            Ram Speed: {ramSpeed} MT/s


            {disks}
            {gpu}
            """;

            // Create the system specs text file
            File.WriteAllText(Path.Combine(@$"C:\Users\{username}\Downloads", "SystemSpecs.txt"), specsText);
        }

        public static void SystemHealth()
        {

        }
    }

    public partial class Form1
    {
        public void SystemSpecsButton_Click(object sender, EventArgs e)
        {
            SystemReports.SystemSpecs();
        }

        public void SystemHealthButton_Click(object sender, EventArgs e)
        {
            SystemReports.SystemHealth();
        }
    }
}