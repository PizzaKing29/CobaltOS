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
        public static string CpuName = "";
        public static string LastBootupTime = "";
        public static string OperatingSystem = "";

        public static bool Is64BitOS = Environment.Is64BitOperatingSystem;
        public static bool IsLaptop = false;

        public static int Cores = 0;
        public static int LogicalProcessers = 0;
        public static int UsedSlots = 0;
        public static int TotalSlots = 0;
        public static int RamSpeed = 0;

        public static double ClockSpeed = 0;
        public static double RamSizeGB = 0;

        public static DateTime TimeNow = DateTime.Now;
        public static DateTime TodaysDate = DateTime.Today;
        public static TimeSpan Time = new TimeSpan();

        public static OperatingSystem OperatingSystemVersion = Environment.OSVersion;
        public static Version Version = OperatingSystemVersion.Version;

        public static StringBuilder disks = new StringBuilder();
        public static StringBuilder gpu = new StringBuilder();

        public static void SystemSpecs()
        {
            if (Version.Build >= 10240 && Version.Build <= 19045)
            {
                OperatingSystem = "Windows 10";
            }
            else if (Version.Build >= 22000 && Version.Build <= 26100)
            {
                OperatingSystem = "Windows 11";
            }

            ManagementObjectCollection bootuptime = new ManagementObjectSearcher("Select LastBootUpTime from Win32_OperatingSystem").Get();
            foreach (var item in bootuptime)
            {
                LastBootupTime = Convert.ToString(item["LastBootUpTime"]);
                LastBootupTime = LastBootupTime.Substring(0, 14);
                Time = TimeNow - DateTime.ParseExact(LastBootupTime, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            }

            try
            {
                ManagementObjectCollection batteryRemaining = new ManagementObjectSearcher("Select EstimatedChargeRemaining from Win32_Battery").Get();
                foreach (var item in batteryRemaining)
                {
                    int batteryPercentage = 0;
                    batteryPercentage = Convert.ToInt32(item["EstimatedChargeRemaining"]);
                    if (batteryPercentage > 0)
                    {
                        IsLaptop = true;
                    }
                    else
                    {
                        IsLaptop = false;
                    }
                }
            }
            catch (Exception)
            {
                IsLaptop = false;
            }

            CpuManagementObjectSearcher();
            RamManagementObjectSearcher();
            DisksManagementObjectSearcher();
            GpuManagementObjectSearcher();
            WriteSystemSpecsFile();
        }

        public static void WriteSystemSpecsFile()
        {
            string systemSpecsText = 
            $"""
            System Specs Script: By PizzaKing29
            -------------------------------

            PC Computer Name: {ConstVariables.ComputerName}
            PC Username: {ConstVariables.Username}
            OS Version: {OperatingSystem}
            64-Bit OS: {Is64BitOS}
            Is Laptop: {IsLaptop}
            Date: {TodaysDate.ToShortDateString()}


            CPU Name: {CpuName}
            CPU Cores: {Cores} cores, {LogicalProcessers} threads
            CPU Base Clock Speed: {ClockSpeed:F2} GHz
            CPU Uptime: {Time.Days} Days, {Time.Hours} Hours, {Time.Minutes} Minutes, {Time.Seconds} Seconds


            Ram Size: {RamSizeGB}GB
            Slots Used: {UsedSlots} of {TotalSlots}
            Ram Speed: {RamSpeed} MT/s


            {disks}
            {gpu}
            """;

            // Create the system specs text file
            string downloadsPath = @$"C:\Users\{ConstVariables.Username}\Downloads";
            File.WriteAllText(Path.Combine(downloadsPath, "SystemSpecs.txt"), systemSpecsText);
        }

        public static void CpuManagementObjectSearcher()
        {
            ManagementObjectCollection cpuCoresAndClockspeed = new ManagementObjectSearcher("Select Name, NumberOfCores, MaxClockSpeed from Win32_Processor").Get();
            foreach (var item in cpuCoresAndClockspeed)
            {
                CpuName = Convert.ToString(item["Name"]);
                Cores += int.Parse(item["NumberOfCores"].ToString());
                ClockSpeed = Math.Round(Convert.ToDouble(item["MaxClockSpeed"]) / 1000.0, 1);
            }

            ManagementObjectCollection logicalProcessors = new ManagementObjectSearcher("Select NumberOfLogicalProcessors from Win32_ComputerSystem").Get();
            foreach (var item in logicalProcessors)
            {
                LogicalProcessers += int.Parse(item["NumberOfLogicalProcessors"].ToString());
            }
        }

        public static void RamManagementObjectSearcher()
        {
            ManagementObjectCollection totalMemory = new ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem").Get();
            foreach (var item in totalMemory)
            {
                RamSizeGB = double.Parse(item["TotalPhysicalMemory"].ToString());
                RamSizeGB = Math.Ceiling(RamSizeGB / (1024.0 * 1024.0 * 1024.0));
            }

            ManagementObjectCollection ramSpeed = new ManagementObjectSearcher("SELECT Speed FROM Win32_PhysicalMemory").Get();
            foreach (var item in ramSpeed)
            {
                UsedSlots++;
                RamSpeed = Convert.ToInt32(item["Speed"]);
            }

            ManagementObjectCollection totalRamSlots = new ManagementObjectSearcher("SELECT MemoryDevices FROM Win32_PhysicalMemoryArray").Get();
            foreach (var item in totalRamSlots)
            {
                TotalSlots += Convert.ToInt32(item["MemoryDevices"]);
            }
        }

        public static void DisksManagementObjectSearcher()
        {
            ManagementObjectCollection diskObjectSearcher = new ManagementObjectSearcher("SELECT Index, Model, InterfaceType, Size FROM Win32_DiskDrive").Get();
            foreach (var item in diskObjectSearcher)
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
        }

        public static void GpuManagementObjectSearcher()
        {
            byte gpuIndex = 0;
            ManagementObjectCollection gpuObjectSearcher = new ManagementObjectSearcher("SELECT Name, DriverVersion, DriverDate FROM Win32_VideoController").Get();
            foreach (var item in gpuObjectSearcher)
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
        }

        public static void SystemHealth()
        {

        }
    }

    public partial class CobaltOS
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