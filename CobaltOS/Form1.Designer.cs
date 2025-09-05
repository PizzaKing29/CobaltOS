namespace CobaltOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Home = new TabControl();
            tabPage1 = new TabPage();
            ParagraphAbout = new Label();
            QuickRepairButton = new Button();
            LastRepairLabel = new Label();
            WelcomeMessage = new Label();
            Optimization = new TabPage();
            OptimizePcOnBoot = new CheckBox();
            AdjustPerformanceWindows = new CheckBox();
            StartOptimizingButton = new Button();
            FasterDNS = new CheckBox();
            TempFileCleaner = new CheckBox();
            GamingOptimization = new CheckBox();
            Repair = new TabPage();
            CheckWindowsUpdate = new CheckBox();
            OutputLogs = new CheckBox();
            BeginRepairButton = new Button();
            BasicCommandRepairs = new CheckBox();
            MalwareScan = new CheckBox();
            EvaluateServices = new CheckBox();
            FindNetworkSeviceIssues = new CheckBox();
            UpdateDrivers = new CheckBox();
            BSODRepair = new CheckBox();
            Utilities = new TabPage();
            NetworkHelpButton = new Button();
            NetworkHelpLabel = new Label();
            HostsFileButton = new Button();
            HostsFileLabel = new Label();
            NetworkTestButton = new Button();
            NetworkTestLabel = new Label();
            QuickIpButton = new Button();
            QuickIpLabel = new Label();
            RegistryEditorButton = new Button();
            RegistryEditorLabel = new Label();
            PortScannerButton = new Button();
            PortScannerLabel = new Label();
            ScriptRunnerButton = new Button();
            ScriptRunnerLabel = new Label();
            BootLogsButton = new Button();
            BootLogsLabel = new Label();
            ProtectedFilesButton = new Button();
            ProtectedFilesLabel = new Label();
            EmptyFolderFinderButton = new Button();
            EmptyFolderFinderLabel = new Label();
            LargeFileFinderButton = new Button();
            LargeFileFinderLabel = new Label();
            GetClipboardButton = new Button();
            GetClipboardLabel = new Label();
            OpenPowershellButton = new Button();
            OpenCmdButton = new Button();
            OpenTerminalLabel = new Label();
            OpenTaskManagerButton = new Button();
            OpenTaskManagerLabel = new Label();
            NetworkUtilities = new Label();
            DeveloperAndPowerUtilities = new Label();
            SystemReportingAndLogs = new Label();
            FileAndStorageUtilities = new Label();
            SystemAndQuickAccess = new Label();
            EnterSafeModeButton = new Button();
            EnterBIOSButton = new Button();
            EnterSafeMode = new Label();
            EnterBIOSLabel = new Label();
            SystemSpecsButton = new Button();
            SystemSpecsLabel = new Label();
            SystemHealthButton = new Button();
            SystemHealthLabel = new Label();
            SearchDupedFilesButton = new Button();
            SearchDupedFilesLabel = new Label();
            Settings = new TabPage();
            ResetToDefaults = new Button();
            SaveSettingsButton = new Button();
            DarkMode = new CheckBox();
            DisableServices = new CheckBox();
            Home.SuspendLayout();
            tabPage1.SuspendLayout();
            Optimization.SuspendLayout();
            Repair.SuspendLayout();
            Utilities.SuspendLayout();
            Settings.SuspendLayout();
            SuspendLayout();
            // 
            // Home
            // 
            Home.Controls.Add(tabPage1);
            Home.Controls.Add(Optimization);
            Home.Controls.Add(Repair);
            Home.Controls.Add(Utilities);
            Home.Controls.Add(Settings);
            Home.Location = new Point(1, 0);
            Home.Multiline = true;
            Home.Name = "Home";
            Home.SelectedIndex = 0;
            Home.Size = new Size(803, 452);
            Home.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ParagraphAbout);
            tabPage1.Controls.Add(QuickRepairButton);
            tabPage1.Controls.Add(LastRepairLabel);
            tabPage1.Controls.Add(WelcomeMessage);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 424);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ParagraphAbout
            // 
            ParagraphAbout.Location = new Point(25, 100);
            ParagraphAbout.Name = "ParagraphAbout";
            ParagraphAbout.Size = new Size(377, 50);
            ParagraphAbout.TabIndex = 4;
            ParagraphAbout.Text = resources.GetString("ParagraphAbout.Text");
            // 
            // QuickRepairButton
            // 
            QuickRepairButton.Location = new Point(25, 200);
            QuickRepairButton.Name = "QuickRepairButton";
            QuickRepairButton.Size = new Size(90, 23);
            QuickRepairButton.TabIndex = 3;
            QuickRepairButton.Text = "Quick Repair";
            QuickRepairButton.UseVisualStyleBackColor = true;
            // 
            // LastRepairLabel
            // 
            LastRepairLabel.AutoSize = true;
            LastRepairLabel.Location = new Point(25, 175);
            LastRepairLabel.Name = "LastRepairLabel";
            LastRepairLabel.Size = new Size(99, 15);
            LastRepairLabel.TabIndex = 2;
            LastRepairLabel.Text = "Last Repair: None";
            // 
            // WelcomeMessage
            // 
            WelcomeMessage.AutoSize = true;
            WelcomeMessage.Font = new Font("Segoe UI", 20F);
            WelcomeMessage.Location = new Point(225, 10);
            WelcomeMessage.Name = "WelcomeMessage";
            WelcomeMessage.Size = new Size(345, 37);
            WelcomeMessage.TabIndex = 0;
            WelcomeMessage.Text = "Welcome to CobaltOS, User";
            // 
            // Optimization
            // 
            Optimization.Controls.Add(DisableServices);
            Optimization.Controls.Add(OptimizePcOnBoot);
            Optimization.Controls.Add(AdjustPerformanceWindows);
            Optimization.Controls.Add(StartOptimizingButton);
            Optimization.Controls.Add(FasterDNS);
            Optimization.Controls.Add(TempFileCleaner);
            Optimization.Controls.Add(GamingOptimization);
            Optimization.Location = new Point(4, 24);
            Optimization.Name = "Optimization";
            Optimization.Padding = new Padding(3);
            Optimization.Size = new Size(795, 424);
            Optimization.TabIndex = 1;
            Optimization.Text = "Optimization";
            Optimization.UseVisualStyleBackColor = true;
            // 
            // OptimizePcOnBoot
            // 
            OptimizePcOnBoot.AutoSize = true;
            OptimizePcOnBoot.Location = new Point(106, 178);
            OptimizePcOnBoot.Name = "OptimizePcOnBoot";
            OptimizePcOnBoot.Size = new Size(137, 19);
            OptimizePcOnBoot.TabIndex = 5;
            OptimizePcOnBoot.Text = "Optimize PC on Boot";
            OptimizePcOnBoot.UseVisualStyleBackColor = true;
            // 
            // AdjustPerformanceWindows
            // 
            AdjustPerformanceWindows.AutoSize = true;
            AdjustPerformanceWindows.Location = new Point(25, 100);
            AdjustPerformanceWindows.Name = "AdjustPerformanceWindows";
            AdjustPerformanceWindows.Size = new Size(300, 19);
            AdjustPerformanceWindows.TabIndex = 4;
            AdjustPerformanceWindows.Text = "Adjust the Apperance and Performance of Windows";
            AdjustPerformanceWindows.UseVisualStyleBackColor = true;
            // 
            // StartOptimizingButton
            // 
            StartOptimizingButton.Location = new Point(25, 175);
            StartOptimizingButton.Name = "StartOptimizingButton";
            StartOptimizingButton.Size = new Size(75, 23);
            StartOptimizingButton.TabIndex = 3;
            StartOptimizingButton.Text = "Optimize";
            StartOptimizingButton.UseVisualStyleBackColor = true;
            StartOptimizingButton.Click += StartOptimizingButton_Click;
            // 
            // FasterDNS
            // 
            FasterDNS.AutoSize = true;
            FasterDNS.Location = new Point(25, 75);
            FasterDNS.Name = "FasterDNS";
            FasterDNS.Size = new Size(83, 19);
            FasterDNS.TabIndex = 2;
            FasterDNS.Text = "Faster DNS";
            FasterDNS.UseVisualStyleBackColor = true;
            // 
            // TempFileCleaner
            // 
            TempFileCleaner.AutoSize = true;
            TempFileCleaner.Location = new Point(25, 50);
            TempFileCleaner.Name = "TempFileCleaner";
            TempFileCleaner.Size = new Size(120, 19);
            TempFileCleaner.TabIndex = 1;
            TempFileCleaner.Text = "Temp File Cleaner";
            TempFileCleaner.UseVisualStyleBackColor = true;
            // 
            // GamingOptimization
            // 
            GamingOptimization.AutoSize = true;
            GamingOptimization.Location = new Point(25, 25);
            GamingOptimization.Name = "GamingOptimization";
            GamingOptimization.Size = new Size(140, 19);
            GamingOptimization.TabIndex = 0;
            GamingOptimization.Text = "Gaming Optimization";
            GamingOptimization.UseVisualStyleBackColor = true;
            // 
            // Repair
            // 
            Repair.Controls.Add(CheckWindowsUpdate);
            Repair.Controls.Add(OutputLogs);
            Repair.Controls.Add(BeginRepairButton);
            Repair.Controls.Add(BasicCommandRepairs);
            Repair.Controls.Add(MalwareScan);
            Repair.Controls.Add(EvaluateServices);
            Repair.Controls.Add(FindNetworkSeviceIssues);
            Repair.Controls.Add(UpdateDrivers);
            Repair.Controls.Add(BSODRepair);
            Repair.Location = new Point(4, 24);
            Repair.Name = "Repair";
            Repair.Padding = new Padding(3);
            Repair.Size = new Size(795, 424);
            Repair.TabIndex = 2;
            Repair.Text = "Repair";
            Repair.UseVisualStyleBackColor = true;
            // 
            // CheckWindowsUpdate
            // 
            CheckWindowsUpdate.AutoSize = true;
            CheckWindowsUpdate.Location = new Point(25, 175);
            CheckWindowsUpdate.Name = "CheckWindowsUpdate";
            CheckWindowsUpdate.Size = new Size(170, 19);
            CheckWindowsUpdate.TabIndex = 8;
            CheckWindowsUpdate.Text = "Check for Windows Update";
            CheckWindowsUpdate.UseVisualStyleBackColor = true;
            // 
            // OutputLogs
            // 
            OutputLogs.AutoSize = true;
            OutputLogs.Location = new Point(106, 228);
            OutputLogs.Name = "OutputLogs";
            OutputLogs.Size = new Size(150, 19);
            OutputLogs.TabIndex = 7;
            OutputLogs.Text = "Output logs as a .txt file";
            OutputLogs.UseVisualStyleBackColor = true;
            // 
            // BeginRepairButton
            // 
            BeginRepairButton.Location = new Point(25, 225);
            BeginRepairButton.Name = "BeginRepairButton";
            BeginRepairButton.Size = new Size(75, 23);
            BeginRepairButton.TabIndex = 6;
            BeginRepairButton.Text = "Begin";
            BeginRepairButton.UseVisualStyleBackColor = true;
            BeginRepairButton.Click += BeginRepairButton_Click;
            // 
            // BasicCommandRepairs
            // 
            BasicCommandRepairs.AutoSize = true;
            BasicCommandRepairs.Location = new Point(25, 150);
            BasicCommandRepairs.Name = "BasicCommandRepairs";
            BasicCommandRepairs.Size = new Size(154, 19);
            BasicCommandRepairs.TabIndex = 5;
            BasicCommandRepairs.Text = "Basic Command Repairs";
            BasicCommandRepairs.UseVisualStyleBackColor = true;
            // 
            // MalwareScan
            // 
            MalwareScan.AutoSize = true;
            MalwareScan.Location = new Point(25, 125);
            MalwareScan.Name = "MalwareScan";
            MalwareScan.Size = new Size(180, 19);
            MalwareScan.TabIndex = 4;
            MalwareScan.Text = "Scan for Viruses and Malware";
            MalwareScan.UseVisualStyleBackColor = true;
            // 
            // EvaluateServices
            // 
            EvaluateServices.AutoSize = true;
            EvaluateServices.Location = new Point(25, 100);
            EvaluateServices.Name = "EvaluateServices";
            EvaluateServices.Size = new Size(115, 19);
            EvaluateServices.TabIndex = 3;
            EvaluateServices.Text = "Evaluate Services";
            EvaluateServices.UseVisualStyleBackColor = true;
            // 
            // FindNetworkSeviceIssues
            // 
            FindNetworkSeviceIssues.AutoSize = true;
            FindNetworkSeviceIssues.Location = new Point(25, 75);
            FindNetworkSeviceIssues.Name = "FindNetworkSeviceIssues";
            FindNetworkSeviceIssues.Size = new Size(167, 19);
            FindNetworkSeviceIssues.TabIndex = 2;
            FindNetworkSeviceIssues.Text = "Find Network Sevice Issues";
            FindNetworkSeviceIssues.UseVisualStyleBackColor = true;
            // 
            // UpdateDrivers
            // 
            UpdateDrivers.AutoSize = true;
            UpdateDrivers.Location = new Point(25, 50);
            UpdateDrivers.Name = "UpdateDrivers";
            UpdateDrivers.Size = new Size(103, 19);
            UpdateDrivers.TabIndex = 1;
            UpdateDrivers.Text = "Update Drivers";
            UpdateDrivers.UseVisualStyleBackColor = true;
            // 
            // BSODRepair
            // 
            BSODRepair.AutoSize = true;
            BSODRepair.Location = new Point(25, 25);
            BSODRepair.Name = "BSODRepair";
            BSODRepair.Size = new Size(92, 19);
            BSODRepair.TabIndex = 0;
            BSODRepair.Text = "BSOD Repair";
            BSODRepair.UseVisualStyleBackColor = true;
            // 
            // Utilities
            // 
            Utilities.Controls.Add(NetworkHelpButton);
            Utilities.Controls.Add(NetworkHelpLabel);
            Utilities.Controls.Add(HostsFileButton);
            Utilities.Controls.Add(HostsFileLabel);
            Utilities.Controls.Add(NetworkTestButton);
            Utilities.Controls.Add(NetworkTestLabel);
            Utilities.Controls.Add(QuickIpButton);
            Utilities.Controls.Add(QuickIpLabel);
            Utilities.Controls.Add(RegistryEditorButton);
            Utilities.Controls.Add(RegistryEditorLabel);
            Utilities.Controls.Add(PortScannerButton);
            Utilities.Controls.Add(PortScannerLabel);
            Utilities.Controls.Add(ScriptRunnerButton);
            Utilities.Controls.Add(ScriptRunnerLabel);
            Utilities.Controls.Add(BootLogsButton);
            Utilities.Controls.Add(BootLogsLabel);
            Utilities.Controls.Add(ProtectedFilesButton);
            Utilities.Controls.Add(ProtectedFilesLabel);
            Utilities.Controls.Add(EmptyFolderFinderButton);
            Utilities.Controls.Add(EmptyFolderFinderLabel);
            Utilities.Controls.Add(LargeFileFinderButton);
            Utilities.Controls.Add(LargeFileFinderLabel);
            Utilities.Controls.Add(GetClipboardButton);
            Utilities.Controls.Add(GetClipboardLabel);
            Utilities.Controls.Add(OpenPowershellButton);
            Utilities.Controls.Add(OpenCmdButton);
            Utilities.Controls.Add(OpenTerminalLabel);
            Utilities.Controls.Add(OpenTaskManagerButton);
            Utilities.Controls.Add(OpenTaskManagerLabel);
            Utilities.Controls.Add(NetworkUtilities);
            Utilities.Controls.Add(DeveloperAndPowerUtilities);
            Utilities.Controls.Add(SystemReportingAndLogs);
            Utilities.Controls.Add(FileAndStorageUtilities);
            Utilities.Controls.Add(SystemAndQuickAccess);
            Utilities.Controls.Add(EnterSafeModeButton);
            Utilities.Controls.Add(EnterBIOSButton);
            Utilities.Controls.Add(EnterSafeMode);
            Utilities.Controls.Add(EnterBIOSLabel);
            Utilities.Controls.Add(SystemSpecsButton);
            Utilities.Controls.Add(SystemSpecsLabel);
            Utilities.Controls.Add(SystemHealthButton);
            Utilities.Controls.Add(SystemHealthLabel);
            Utilities.Controls.Add(SearchDupedFilesButton);
            Utilities.Controls.Add(SearchDupedFilesLabel);
            Utilities.Location = new Point(4, 24);
            Utilities.Name = "Utilities";
            Utilities.Padding = new Padding(3);
            Utilities.Size = new Size(795, 424);
            Utilities.TabIndex = 3;
            Utilities.Text = "Utilities";
            Utilities.UseVisualStyleBackColor = true;
            // 
            // NetworkHelpButton
            // 
            NetworkHelpButton.Location = new Point(661, 309);
            NetworkHelpButton.Name = "NetworkHelpButton";
            NetworkHelpButton.Size = new Size(75, 23);
            NetworkHelpButton.TabIndex = 47;
            NetworkHelpButton.Text = "Find Issues";
            NetworkHelpButton.UseVisualStyleBackColor = true;
            NetworkHelpButton.Click += NetworkHelpButton_Click;
            // 
            // NetworkHelpLabel
            // 
            NetworkHelpLabel.AutoSize = true;
            NetworkHelpLabel.Location = new Point(486, 313);
            NetworkHelpLabel.Name = "NetworkHelpLabel";
            NetworkHelpLabel.Size = new Size(169, 15);
            NetworkHelpLabel.TabIndex = 46;
            NetworkHelpLabel.Text = "Quick Network Troubleshooter";
            // 
            // HostsFileButton
            // 
            HostsFileButton.Location = new Point(584, 284);
            HostsFileButton.Name = "HostsFileButton";
            HostsFileButton.Size = new Size(75, 23);
            HostsFileButton.TabIndex = 45;
            HostsFileButton.Text = "Edit File";
            HostsFileButton.UseVisualStyleBackColor = true;
            HostsFileButton.Click += HostsFileButton_Click;
            // 
            // HostsFileLabel
            // 
            HostsFileLabel.AutoSize = true;
            HostsFileLabel.Location = new Point(486, 288);
            HostsFileLabel.Name = "HostsFileLabel";
            HostsFileLabel.Size = new Size(92, 15);
            HostsFileLabel.TabIndex = 44;
            HostsFileLabel.Text = "Hosts File Editor";
            // 
            // NetworkTestButton
            // 
            NetworkTestButton.Location = new Point(605, 259);
            NetworkTestButton.Name = "NetworkTestButton";
            NetworkTestButton.Size = new Size(75, 23);
            NetworkTestButton.TabIndex = 43;
            NetworkTestButton.Text = "Test Speed";
            NetworkTestButton.UseVisualStyleBackColor = true;
            NetworkTestButton.Click += NetworkTestButton_Click;
            // 
            // NetworkTestLabel
            // 
            NetworkTestLabel.AutoSize = true;
            NetworkTestLabel.Location = new Point(486, 263);
            NetworkTestLabel.Name = "NetworkTestLabel";
            NetworkTestLabel.Size = new Size(111, 15);
            NetworkTestLabel.TabIndex = 42;
            NetworkTestLabel.Text = "Network Speed Test";
            // 
            // QuickIpButton
            // 
            QuickIpButton.Location = new Point(605, 234);
            QuickIpButton.Name = "QuickIpButton";
            QuickIpButton.Size = new Size(75, 23);
            QuickIpButton.TabIndex = 41;
            QuickIpButton.Text = "Get Info";
            QuickIpButton.UseVisualStyleBackColor = true;
            QuickIpButton.Click += QuickIpButton_Click;
            // 
            // QuickIpLabel
            // 
            QuickIpLabel.AutoSize = true;
            QuickIpLabel.Location = new Point(486, 238);
            QuickIpLabel.Name = "QuickIpLabel";
            QuickIpLabel.Size = new Size(113, 15);
            QuickIpLabel.TabIndex = 40;
            QuickIpLabel.Text = "Quick IP / MAC Info";
            // 
            // RegistryEditorButton
            // 
            RegistryEditorButton.Location = new Point(153, 284);
            RegistryEditorButton.Name = "RegistryEditorButton";
            RegistryEditorButton.Size = new Size(75, 23);
            RegistryEditorButton.TabIndex = 39;
            RegistryEditorButton.Text = "Open";
            RegistryEditorButton.UseVisualStyleBackColor = true;
            RegistryEditorButton.Click += RegistryEditorButton_Click;
            // 
            // RegistryEditorLabel
            // 
            RegistryEditorLabel.AutoSize = true;
            RegistryEditorLabel.Location = new Point(4, 288);
            RegistryEditorLabel.Name = "RegistryEditorLabel";
            RegistryEditorLabel.Size = new Size(143, 15);
            RegistryEditorLabel.TabIndex = 38;
            RegistryEditorLabel.Text = "Registry Snapshot / Editor";
            // 
            // PortScannerButton
            // 
            PortScannerButton.Location = new Point(84, 259);
            PortScannerButton.Name = "PortScannerButton";
            PortScannerButton.Size = new Size(75, 23);
            PortScannerButton.TabIndex = 37;
            PortScannerButton.Text = "Scan Ports";
            PortScannerButton.UseVisualStyleBackColor = true;
            PortScannerButton.Click += PortScannerButton_Click;
            // 
            // PortScannerLabel
            // 
            PortScannerLabel.AutoSize = true;
            PortScannerLabel.Location = new Point(4, 263);
            PortScannerLabel.Name = "PortScannerLabel";
            PortScannerLabel.Size = new Size(74, 15);
            PortScannerLabel.TabIndex = 36;
            PortScannerLabel.Text = "Port Scanner";
            // 
            // ScriptRunnerButton
            // 
            ScriptRunnerButton.Location = new Point(87, 234);
            ScriptRunnerButton.Name = "ScriptRunnerButton";
            ScriptRunnerButton.Size = new Size(75, 23);
            ScriptRunnerButton.TabIndex = 35;
            ScriptRunnerButton.Text = "Open";
            ScriptRunnerButton.UseVisualStyleBackColor = true;
            ScriptRunnerButton.Click += ScriptRunnerButton_Click;
            // 
            // ScriptRunnerLabel
            // 
            ScriptRunnerLabel.AutoSize = true;
            ScriptRunnerLabel.Location = new Point(3, 238);
            ScriptRunnerLabel.Name = "ScriptRunnerLabel";
            ScriptRunnerLabel.Size = new Size(78, 15);
            ScriptRunnerLabel.TabIndex = 34;
            ScriptRunnerLabel.Text = "Script Runner";
            // 
            // BootLogsButton
            // 
            BootLogsButton.Location = new Point(641, 84);
            BootLogsButton.Name = "BootLogsButton";
            BootLogsButton.Size = new Size(75, 23);
            BootLogsButton.TabIndex = 33;
            BootLogsButton.Text = "View Logs";
            BootLogsButton.UseVisualStyleBackColor = true;
            BootLogsButton.Click += BootLogsButton_Click;
            // 
            // BootLogsLabel
            // 
            BootLogsLabel.AutoSize = true;
            BootLogsLabel.Location = new Point(542, 88);
            BootLogsLabel.Name = "BootLogsLabel";
            BootLogsLabel.Size = new Size(93, 15);
            BootLogsLabel.TabIndex = 32;
            BootLogsLabel.Text = "Boot Log Viewer";
            // 
            // ProtectedFilesButton
            // 
            ProtectedFilesButton.Location = new Point(423, 109);
            ProtectedFilesButton.Name = "ProtectedFilesButton";
            ProtectedFilesButton.Size = new Size(75, 23);
            ProtectedFilesButton.TabIndex = 31;
            ProtectedFilesButton.Text = "Show";
            ProtectedFilesButton.UseVisualStyleBackColor = true;
            ProtectedFilesButton.Click += ProtectedFilesButton_Click;
            // 
            // ProtectedFilesLabel
            // 
            ProtectedFilesLabel.AutoSize = true;
            ProtectedFilesLabel.Location = new Point(265, 113);
            ProtectedFilesLabel.Name = "ProtectedFilesLabel";
            ProtectedFilesLabel.Size = new Size(152, 15);
            ProtectedFilesLabel.TabIndex = 30;
            ProtectedFilesLabel.Text = "Show / Hide Protected Files";
            // 
            // EmptyFolderFinderButton
            // 
            EmptyFolderFinderButton.Location = new Point(384, 84);
            EmptyFolderFinderButton.Name = "EmptyFolderFinderButton";
            EmptyFolderFinderButton.Size = new Size(75, 23);
            EmptyFolderFinderButton.TabIndex = 29;
            EmptyFolderFinderButton.Text = "Locate";
            EmptyFolderFinderButton.UseVisualStyleBackColor = true;
            EmptyFolderFinderButton.Click += EmptyFolderFinderButton_Click;
            // 
            // EmptyFolderFinderLabel
            // 
            EmptyFolderFinderLabel.AutoSize = true;
            EmptyFolderFinderLabel.Location = new Point(265, 88);
            EmptyFolderFinderLabel.Name = "EmptyFolderFinderLabel";
            EmptyFolderFinderLabel.Size = new Size(113, 15);
            EmptyFolderFinderLabel.TabIndex = 28;
            EmptyFolderFinderLabel.Text = "Empty Folder Finder";
            // 
            // LargeFileFinderButton
            // 
            LargeFileFinderButton.Location = new Point(364, 59);
            LargeFileFinderButton.Name = "LargeFileFinderButton";
            LargeFileFinderButton.Size = new Size(75, 23);
            LargeFileFinderButton.TabIndex = 27;
            LargeFileFinderButton.Text = "Find Files";
            LargeFileFinderButton.UseVisualStyleBackColor = true;
            LargeFileFinderButton.Click += LargeFileFinderButton_Click;
            // 
            // LargeFileFinderLabel
            // 
            LargeFileFinderLabel.AutoSize = true;
            LargeFileFinderLabel.Location = new Point(265, 63);
            LargeFileFinderLabel.Name = "LargeFileFinderLabel";
            LargeFileFinderLabel.Size = new Size(93, 15);
            LargeFileFinderLabel.TabIndex = 26;
            LargeFileFinderLabel.Text = "Large File Finder";
            // 
            // GetClipboardButton
            // 
            GetClipboardButton.Location = new Point(128, 161);
            GetClipboardButton.Name = "GetClipboardButton";
            GetClipboardButton.Size = new Size(75, 23);
            GetClipboardButton.TabIndex = 25;
            GetClipboardButton.Text = "Copy";
            GetClipboardButton.UseVisualStyleBackColor = true;
            GetClipboardButton.Click += GetClipboardButton_Click;
            // 
            // GetClipboardLabel
            // 
            GetClipboardLabel.AutoSize = true;
            GetClipboardLabel.Location = new Point(3, 165);
            GetClipboardLabel.Name = "GetClipboardLabel";
            GetClipboardLabel.Size = new Size(119, 15);
            GetClipboardLabel.TabIndex = 24;
            GetClipboardLabel.Text = "Get Recent Clipboard";
            // 
            // OpenPowershellButton
            // 
            OpenPowershellButton.Location = new Point(84, 131);
            OpenPowershellButton.Name = "OpenPowershellButton";
            OpenPowershellButton.Size = new Size(75, 23);
            OpenPowershellButton.TabIndex = 23;
            OpenPowershellButton.Text = "Powershell";
            OpenPowershellButton.UseVisualStyleBackColor = true;
            OpenPowershellButton.Click += OpenPowershellButton_Click;
            // 
            // OpenCmdButton
            // 
            OpenCmdButton.Location = new Point(3, 131);
            OpenCmdButton.Name = "OpenCmdButton";
            OpenCmdButton.Size = new Size(75, 23);
            OpenCmdButton.TabIndex = 22;
            OpenCmdButton.Text = "Cmd";
            OpenCmdButton.UseVisualStyleBackColor = true;
            OpenCmdButton.Click += OpenCmdButton_Click;
            // 
            // OpenTerminalLabel
            // 
            OpenTerminalLabel.AutoSize = true;
            OpenTerminalLabel.Location = new Point(3, 113);
            OpenTerminalLabel.Name = "OpenTerminalLabel";
            OpenTerminalLabel.Size = new Size(138, 15);
            OpenTerminalLabel.TabIndex = 21;
            OpenTerminalLabel.Text = "Open Terminal as Admin";
            // 
            // OpenTaskManagerButton
            // 
            OpenTaskManagerButton.Location = new Point(121, 84);
            OpenTaskManagerButton.Name = "OpenTaskManagerButton";
            OpenTaskManagerButton.Size = new Size(75, 23);
            OpenTaskManagerButton.TabIndex = 20;
            OpenTaskManagerButton.Text = "Open";
            OpenTaskManagerButton.UseVisualStyleBackColor = true;
            OpenTaskManagerButton.Click += OpenTaskManagerButton_Click;
            // 
            // OpenTaskManagerLabel
            // 
            OpenTaskManagerLabel.AutoSize = true;
            OpenTaskManagerLabel.Location = new Point(3, 88);
            OpenTaskManagerLabel.Name = "OpenTaskManagerLabel";
            OpenTaskManagerLabel.Size = new Size(112, 15);
            OpenTaskManagerLabel.TabIndex = 19;
            OpenTaskManagerLabel.Text = "Open Task Manager";
            // 
            // NetworkUtilities
            // 
            NetworkUtilities.AutoSize = true;
            NetworkUtilities.Font = new Font("Segoe UI", 15F);
            NetworkUtilities.Location = new Point(482, 200);
            NetworkUtilities.Name = "NetworkUtilities";
            NetworkUtilities.Size = new Size(313, 28);
            NetworkUtilities.TabIndex = 18;
            NetworkUtilities.Text = "Network And Connectivity Utilities";
            // 
            // DeveloperAndPowerUtilities
            // 
            DeveloperAndPowerUtilities.AutoSize = true;
            DeveloperAndPowerUtilities.Font = new Font("Segoe UI", 15F);
            DeveloperAndPowerUtilities.Location = new Point(0, 200);
            DeveloperAndPowerUtilities.Name = "DeveloperAndPowerUtilities";
            DeveloperAndPowerUtilities.Size = new Size(288, 28);
            DeveloperAndPowerUtilities.TabIndex = 17;
            DeveloperAndPowerUtilities.Text = "Developer / Power User Utilities";
            // 
            // SystemReportingAndLogs
            // 
            SystemReportingAndLogs.AutoSize = true;
            SystemReportingAndLogs.Font = new Font("Segoe UI", 15F);
            SystemReportingAndLogs.Location = new Point(542, 0);
            SystemReportingAndLogs.Name = "SystemReportingAndLogs";
            SystemReportingAndLogs.Size = new Size(253, 28);
            SystemReportingAndLogs.TabIndex = 16;
            SystemReportingAndLogs.Text = "System Reporting And Logs";
            // 
            // FileAndStorageUtilities
            // 
            FileAndStorageUtilities.AutoSize = true;
            FileAndStorageUtilities.Font = new Font("Segoe UI", 15F);
            FileAndStorageUtilities.Location = new Point(265, 0);
            FileAndStorageUtilities.Name = "FileAndStorageUtilities";
            FileAndStorageUtilities.Size = new Size(227, 28);
            FileAndStorageUtilities.TabIndex = 15;
            FileAndStorageUtilities.Text = "File And Storage Utilities";
            // 
            // SystemAndQuickAccess
            // 
            SystemAndQuickAccess.AutoSize = true;
            SystemAndQuickAccess.Font = new Font("Segoe UI", 15F);
            SystemAndQuickAccess.Location = new Point(0, 0);
            SystemAndQuickAccess.Name = "SystemAndQuickAccess";
            SystemAndQuickAccess.Size = new Size(232, 28);
            SystemAndQuickAccess.TabIndex = 14;
            SystemAndQuickAccess.Text = "System And Quick Access";
            // 
            // EnterSafeModeButton
            // 
            EnterSafeModeButton.Location = new Point(102, 59);
            EnterSafeModeButton.Name = "EnterSafeModeButton";
            EnterSafeModeButton.Size = new Size(75, 23);
            EnterSafeModeButton.TabIndex = 13;
            EnterSafeModeButton.Text = "Enter";
            EnterSafeModeButton.UseVisualStyleBackColor = true;
            EnterSafeModeButton.Click += EnterSafeModeButton_Click;
            // 
            // EnterBIOSButton
            // 
            EnterBIOSButton.Location = new Point(71, 34);
            EnterBIOSButton.Name = "EnterBIOSButton";
            EnterBIOSButton.Size = new Size(75, 23);
            EnterBIOSButton.TabIndex = 12;
            EnterBIOSButton.Text = "Enter BIOS";
            EnterBIOSButton.UseVisualStyleBackColor = true;
            EnterBIOSButton.Click += EnterBIOSButton_Click;
            // 
            // EnterSafeMode
            // 
            EnterSafeMode.AutoSize = true;
            EnterSafeMode.Location = new Point(3, 63);
            EnterSafeMode.Name = "EnterSafeMode";
            EnterSafeMode.Size = new Size(93, 15);
            EnterSafeMode.TabIndex = 11;
            EnterSafeMode.Text = "Enter Safe Mode";
            // 
            // EnterBIOSLabel
            // 
            EnterBIOSLabel.AutoSize = true;
            EnterBIOSLabel.Location = new Point(3, 38);
            EnterBIOSLabel.Name = "EnterBIOSLabel";
            EnterBIOSLabel.Size = new Size(62, 15);
            EnterBIOSLabel.TabIndex = 10;
            EnterBIOSLabel.Text = "Enter BIOS";
            // 
            // SystemSpecsButton
            // 
            SystemSpecsButton.Location = new Point(717, 34);
            SystemSpecsButton.Name = "SystemSpecsButton";
            SystemSpecsButton.Size = new Size(75, 23);
            SystemSpecsButton.TabIndex = 9;
            SystemSpecsButton.Text = "Create";
            SystemSpecsButton.UseVisualStyleBackColor = true;
            SystemSpecsButton.Click += SystemSpecsButton_Click;
            // 
            // SystemSpecsLabel
            // 
            SystemSpecsLabel.AutoSize = true;
            SystemSpecsLabel.Location = new Point(542, 38);
            SystemSpecsLabel.Name = "SystemSpecsLabel";
            SystemSpecsLabel.Size = new Size(176, 15);
            SystemSpecsLabel.TabIndex = 8;
            SystemSpecsLabel.Text = "Create a .txt file of System Specs";
            // 
            // SystemHealthButton
            // 
            SystemHealthButton.Location = new Point(652, 59);
            SystemHealthButton.Name = "SystemHealthButton";
            SystemHealthButton.Size = new Size(75, 23);
            SystemHealthButton.TabIndex = 7;
            SystemHealthButton.Text = "Show";
            SystemHealthButton.UseVisualStyleBackColor = true;
            SystemHealthButton.Click += SystemHealthButton_Click;
            // 
            // SystemHealthLabel
            // 
            SystemHealthLabel.AutoSize = true;
            SystemHealthLabel.Location = new Point(542, 63);
            SystemHealthLabel.Name = "SystemHealthLabel";
            SystemHealthLabel.Size = new Size(104, 15);
            SystemHealthLabel.TabIndex = 6;
            SystemHealthLabel.Text = "Get System Health";
            // 
            // SearchDupedFilesButton
            // 
            SearchDupedFilesButton.Location = new Point(410, 34);
            SearchDupedFilesButton.Name = "SearchDupedFilesButton";
            SearchDupedFilesButton.Size = new Size(75, 23);
            SearchDupedFilesButton.TabIndex = 3;
            SearchDupedFilesButton.Text = "Search";
            SearchDupedFilesButton.UseVisualStyleBackColor = true;
            SearchDupedFilesButton.Click += SearchDupedFilesButton_Click;
            // 
            // SearchDupedFilesLabel
            // 
            SearchDupedFilesLabel.AutoSize = true;
            SearchDupedFilesLabel.Location = new Point(265, 38);
            SearchDupedFilesLabel.Name = "SearchDupedFilesLabel";
            SearchDupedFilesLabel.Size = new Size(139, 15);
            SearchDupedFilesLabel.TabIndex = 2;
            SearchDupedFilesLabel.Text = "Search for Duplicate Files";
            // 
            // Settings
            // 
            Settings.Controls.Add(ResetToDefaults);
            Settings.Controls.Add(SaveSettingsButton);
            Settings.Controls.Add(DarkMode);
            Settings.Location = new Point(4, 24);
            Settings.Name = "Settings";
            Settings.Padding = new Padding(3);
            Settings.Size = new Size(795, 424);
            Settings.TabIndex = 4;
            Settings.Text = "Settings";
            Settings.UseVisualStyleBackColor = true;
            // 
            // ResetToDefaults
            // 
            ResetToDefaults.Location = new Point(106, 50);
            ResetToDefaults.Name = "ResetToDefaults";
            ResetToDefaults.Size = new Size(75, 23);
            ResetToDefaults.TabIndex = 3;
            ResetToDefaults.Text = "Reset";
            ResetToDefaults.UseVisualStyleBackColor = true;
            // 
            // SaveSettingsButton
            // 
            SaveSettingsButton.Location = new Point(25, 50);
            SaveSettingsButton.Name = "SaveSettingsButton";
            SaveSettingsButton.Size = new Size(75, 23);
            SaveSettingsButton.TabIndex = 2;
            SaveSettingsButton.Text = "Save";
            SaveSettingsButton.UseVisualStyleBackColor = true;
            // 
            // DarkMode
            // 
            DarkMode.AutoSize = true;
            DarkMode.Location = new Point(25, 25);
            DarkMode.Name = "DarkMode";
            DarkMode.Size = new Size(84, 19);
            DarkMode.TabIndex = 1;
            DarkMode.Text = "Dark Mode";
            DarkMode.UseVisualStyleBackColor = true;
            // 
            // DisableServices
            // 
            DisableServices.AutoSize = true;
            DisableServices.Location = new Point(25, 125);
            DisableServices.Name = "DisableServices";
            DisableServices.Size = new Size(178, 19);
            DisableServices.TabIndex = 6;
            DisableServices.Text = "Disable Unnecessary Services";
            DisableServices.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Home);
            Name = "Form1";
            Text = "CobaltOS";
            Load += Form1_Load;
            Home.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            Optimization.ResumeLayout(false);
            Optimization.PerformLayout();
            Repair.ResumeLayout(false);
            Repair.PerformLayout();
            Utilities.ResumeLayout(false);
            Utilities.PerformLayout();
            Settings.ResumeLayout(false);
            Settings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Home;
        private TabPage tabPage1;
        private TabPage Optimization;
        private TabPage Repair;
        private TabPage Utilities;
        private TabPage Settings;
        private CheckBox GamingOptimization;
        private CheckBox FasterDNS;
        private CheckBox TempFileCleaner;
        private CheckBox EvaluateServices;
        private CheckBox FindNetworkSeviceIssues;
        private CheckBox UpdateDrivers;
        private CheckBox BSODRepair;
        private CheckBox BasicCommandRepairs;
        private CheckBox MalwareScan;
        private Button SearchDupedFilesButton;
        private Label SearchDupedFilesLabel;
        private CheckBox OutputLogs;
        private Button BeginRepairButton;
        private Button SystemSpecsButton;
        private Label SystemSpecsLabel;
        private Button SystemHealthButton;
        private Label SystemHealthLabel;
        private Button StartOptimizingButton;
        private Label EnterSafeMode;
        private Label EnterBIOSLabel;
        private Button EnterBIOSButton;
        private Button EnterSafeModeButton;
        private Button SaveSettingsButton;
        private CheckBox DarkMode;
        private Button ResetToDefaults;
        private Button QuickRepairButton;
        private Label LastRepairLabel;
        private Label WelcomeMessage;
        private Label ParagraphAbout;
        private CheckBox CheckWindowsUpdate;
        private CheckBox AdjustPerformanceWindows;
        private CheckBox OptimizePcOnBoot;
        private Label SystemReportingAndLogs;
        private Label FileAndStorageUtilities;
        private Label SystemAndQuickAccess;
        private Label OpenTerminalLabel;
        private Button OpenTaskManagerButton;
        private Label OpenTaskManagerLabel;
        private Label NetworkUtilities;
        private Label DeveloperAndPowerUtilities;
        private Button GetClipboardButton;
        private Label GetClipboardLabel;
        private Button OpenPowershellButton;
        private Button OpenCmdButton;
        private Button EmptyFolderFinderButton;
        private Label EmptyFolderFinderLabel;
        private Button LargeFileFinderButton;
        private Label LargeFileFinderLabel;
        private Label QuickIpLabel;
        private Button RegistryEditorButton;
        private Label RegistryEditorLabel;
        private Button PortScannerButton;
        private Label PortScannerLabel;
        private Button ScriptRunnerButton;
        private Label ScriptRunnerLabel;
        private Button BootLogsButton;
        private Label BootLogsLabel;
        private Button ProtectedFilesButton;
        private Label ProtectedFilesLabel;
        private Label NetworkTestLabel;
        private Button QuickIpButton;
        private Button HostsFileButton;
        private Label HostsFileLabel;
        private Button NetworkTestButton;
        private Button NetworkHelpButton;
        private Label NetworkHelpLabel;
        private CheckBox DisableServices;
    }
}
