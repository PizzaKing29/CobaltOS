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
            QuickRepair = new Button();
            LastRepair = new Label();
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
            button4 = new Button();
            label8 = new Label();
            button3 = new Button();
            button2 = new Button();
            label7 = new Label();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            EnterSafeModeButton = new Button();
            EnterBIOSButton = new Button();
            EnterSafeMode = new Label();
            EnterBIOS = new Label();
            CreateSpecsButton = new Button();
            CreateFile = new Label();
            AdvancedStatsButton = new Button();
            AdvancedSystemStats = new Label();
            SearchForDupedFiles = new Button();
            SearchDupedFiles = new Label();
            Settings = new TabPage();
            ResetToDefaults = new Button();
            SaveSettingsButton = new Button();
            DarkMode = new CheckBox();
            label9 = new Label();
            button5 = new Button();
            label10 = new Label();
            button6 = new Button();
            label11 = new Label();
            button7 = new Button();
            label12 = new Label();
            button8 = new Button();
            label13 = new Label();
            button9 = new Button();
            label14 = new Label();
            button10 = new Button();
            label15 = new Label();
            button11 = new Button();
            label16 = new Label();
            button12 = new Button();
            label17 = new Label();
            button13 = new Button();
            label18 = new Label();
            button14 = new Button();
            label19 = new Label();
            button15 = new Button();
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
            tabPage1.Controls.Add(QuickRepair);
            tabPage1.Controls.Add(LastRepair);
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
            // QuickRepair
            // 
            QuickRepair.Location = new Point(25, 200);
            QuickRepair.Name = "QuickRepair";
            QuickRepair.Size = new Size(90, 23);
            QuickRepair.TabIndex = 3;
            QuickRepair.Text = "Quick Repair";
            QuickRepair.UseVisualStyleBackColor = true;
            QuickRepair.Click += QuickRepair_Click;
            // 
            // LastRepair
            // 
            LastRepair.AutoSize = true;
            LastRepair.Location = new Point(25, 175);
            LastRepair.Name = "LastRepair";
            LastRepair.Size = new Size(99, 15);
            LastRepair.TabIndex = 2;
            LastRepair.Text = "Last Repair: None";
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
            OptimizePcOnBoot.Location = new Point(106, 153);
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
            StartOptimizingButton.Location = new Point(25, 150);
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
            Utilities.Controls.Add(button15);
            Utilities.Controls.Add(label19);
            Utilities.Controls.Add(button14);
            Utilities.Controls.Add(label18);
            Utilities.Controls.Add(button13);
            Utilities.Controls.Add(label17);
            Utilities.Controls.Add(button12);
            Utilities.Controls.Add(label16);
            Utilities.Controls.Add(button11);
            Utilities.Controls.Add(label15);
            Utilities.Controls.Add(button10);
            Utilities.Controls.Add(label14);
            Utilities.Controls.Add(button9);
            Utilities.Controls.Add(label13);
            Utilities.Controls.Add(button8);
            Utilities.Controls.Add(label12);
            Utilities.Controls.Add(button7);
            Utilities.Controls.Add(label11);
            Utilities.Controls.Add(button6);
            Utilities.Controls.Add(label10);
            Utilities.Controls.Add(button5);
            Utilities.Controls.Add(label9);
            Utilities.Controls.Add(button4);
            Utilities.Controls.Add(label8);
            Utilities.Controls.Add(button3);
            Utilities.Controls.Add(button2);
            Utilities.Controls.Add(label7);
            Utilities.Controls.Add(button1);
            Utilities.Controls.Add(label6);
            Utilities.Controls.Add(label5);
            Utilities.Controls.Add(label4);
            Utilities.Controls.Add(label3);
            Utilities.Controls.Add(label2);
            Utilities.Controls.Add(label1);
            Utilities.Controls.Add(EnterSafeModeButton);
            Utilities.Controls.Add(EnterBIOSButton);
            Utilities.Controls.Add(EnterSafeMode);
            Utilities.Controls.Add(EnterBIOS);
            Utilities.Controls.Add(CreateSpecsButton);
            Utilities.Controls.Add(CreateFile);
            Utilities.Controls.Add(AdvancedStatsButton);
            Utilities.Controls.Add(AdvancedSystemStats);
            Utilities.Controls.Add(SearchForDupedFiles);
            Utilities.Controls.Add(SearchDupedFiles);
            Utilities.Location = new Point(4, 24);
            Utilities.Name = "Utilities";
            Utilities.Padding = new Padding(3);
            Utilities.Size = new Size(795, 424);
            Utilities.TabIndex = 3;
            Utilities.Text = "Utilities";
            Utilities.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(128, 161);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 25;
            button4.Text = "Copy";
            button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 165);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 24;
            label8.Text = "Get Recent Clipboard";
            // 
            // button3
            // 
            button3.Location = new Point(84, 131);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 23;
            button3.Text = "Powershell";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 131);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 22;
            button2.Text = "Cmd";
            button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 113);
            label7.Name = "label7";
            label7.Size = new Size(138, 15);
            label7.TabIndex = 21;
            label7.Text = "Open Terminal as Admin";
            // 
            // button1
            // 
            button1.Location = new Point(121, 84);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 88);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 19;
            label6.Text = "Open Task Manager";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(482, 200);
            label5.Name = "label5";
            label5.Size = new Size(313, 28);
            label5.TabIndex = 18;
            label5.Text = "Network And Connectivity Utilities";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(0, 200);
            label4.Name = "label4";
            label4.Size = new Size(288, 28);
            label4.TabIndex = 17;
            label4.Text = "Developer / Power User Utilities";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(542, 0);
            label3.Name = "label3";
            label3.Size = new Size(253, 28);
            label3.TabIndex = 16;
            label3.Text = "System Reporting And Logs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(265, 0);
            label2.Name = "label2";
            label2.Size = new Size(227, 28);
            label2.TabIndex = 15;
            label2.Text = "File And Storage Utilities";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 28);
            label1.TabIndex = 14;
            label1.Text = "System And Quick Access";
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
            // EnterBIOS
            // 
            EnterBIOS.AutoSize = true;
            EnterBIOS.Location = new Point(3, 38);
            EnterBIOS.Name = "EnterBIOS";
            EnterBIOS.Size = new Size(62, 15);
            EnterBIOS.TabIndex = 10;
            EnterBIOS.Text = "Enter BIOS";
            // 
            // CreateSpecsButton
            // 
            CreateSpecsButton.Location = new Point(717, 34);
            CreateSpecsButton.Name = "CreateSpecsButton";
            CreateSpecsButton.Size = new Size(75, 23);
            CreateSpecsButton.TabIndex = 9;
            CreateSpecsButton.Text = "Create";
            CreateSpecsButton.UseVisualStyleBackColor = true;
            CreateSpecsButton.Click += CreateSpecsButton_Click;
            // 
            // CreateFile
            // 
            CreateFile.AutoSize = true;
            CreateFile.Location = new Point(542, 38);
            CreateFile.Name = "CreateFile";
            CreateFile.Size = new Size(176, 15);
            CreateFile.TabIndex = 8;
            CreateFile.Text = "Create a .txt file of System Specs";
            // 
            // AdvancedStatsButton
            // 
            AdvancedStatsButton.Location = new Point(652, 59);
            AdvancedStatsButton.Name = "AdvancedStatsButton";
            AdvancedStatsButton.Size = new Size(75, 23);
            AdvancedStatsButton.TabIndex = 7;
            AdvancedStatsButton.Text = "Show";
            AdvancedStatsButton.UseVisualStyleBackColor = true;
            AdvancedStatsButton.Click += AdvancedStatsButton_Click;
            // 
            // AdvancedSystemStats
            // 
            AdvancedSystemStats.AutoSize = true;
            AdvancedSystemStats.Location = new Point(542, 63);
            AdvancedSystemStats.Name = "AdvancedSystemStats";
            AdvancedSystemStats.Size = new Size(104, 15);
            AdvancedSystemStats.TabIndex = 6;
            AdvancedSystemStats.Text = "Get System Health";
            // 
            // SearchForDupedFiles
            // 
            SearchForDupedFiles.Location = new Point(410, 34);
            SearchForDupedFiles.Name = "SearchForDupedFiles";
            SearchForDupedFiles.Size = new Size(75, 23);
            SearchForDupedFiles.TabIndex = 3;
            SearchForDupedFiles.Text = "Search";
            SearchForDupedFiles.UseVisualStyleBackColor = true;
            SearchForDupedFiles.Click += SearchForDupedFiles_Click;
            // 
            // SearchDupedFiles
            // 
            SearchDupedFiles.AutoSize = true;
            SearchDupedFiles.Location = new Point(265, 38);
            SearchDupedFiles.Name = "SearchDupedFiles";
            SearchDupedFiles.Size = new Size(139, 15);
            SearchDupedFiles.TabIndex = 2;
            SearchDupedFiles.Text = "Search for Duplicate Files";
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(265, 63);
            label9.Name = "label9";
            label9.Size = new Size(93, 15);
            label9.TabIndex = 26;
            label9.Text = "Large File Finder";
            // 
            // button5
            // 
            button5.Location = new Point(364, 59);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 27;
            button5.Text = "Find Files";
            button5.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(265, 88);
            label10.Name = "label10";
            label10.Size = new Size(113, 15);
            label10.TabIndex = 28;
            label10.Text = "Empty Folder Finder";
            // 
            // button6
            // 
            button6.Location = new Point(384, 84);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 29;
            button6.Text = "Locate";
            button6.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(265, 113);
            label11.Name = "label11";
            label11.Size = new Size(152, 15);
            label11.TabIndex = 30;
            label11.Text = "Show / Hide Protected Files";
            // 
            // button7
            // 
            button7.Location = new Point(423, 109);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 31;
            button7.Text = "Show";
            button7.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(542, 88);
            label12.Name = "label12";
            label12.Size = new Size(93, 15);
            label12.TabIndex = 32;
            label12.Text = "Boot Log Viewer";
            // 
            // button8
            // 
            button8.Location = new Point(641, 84);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 33;
            button8.Text = "View Logs";
            button8.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 238);
            label13.Name = "label13";
            label13.Size = new Size(78, 15);
            label13.TabIndex = 34;
            label13.Text = "Script Runner";
            // 
            // button9
            // 
            button9.Location = new Point(87, 234);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 35;
            button9.Text = "Open";
            button9.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(4, 263);
            label14.Name = "label14";
            label14.Size = new Size(74, 15);
            label14.TabIndex = 36;
            label14.Text = "Port Scanner";
            // 
            // button10
            // 
            button10.Location = new Point(84, 259);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 37;
            button10.Text = "Scan Ports";
            button10.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(4, 288);
            label15.Name = "label15";
            label15.Size = new Size(143, 15);
            label15.TabIndex = 38;
            label15.Text = "Registry Snapshot / Editor";
            // 
            // button11
            // 
            button11.Location = new Point(153, 284);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 39;
            button11.Text = "Open";
            button11.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(486, 238);
            label16.Name = "label16";
            label16.Size = new Size(113, 15);
            label16.TabIndex = 40;
            label16.Text = "Quick IP / MAC Info";
            // 
            // button12
            // 
            button12.Location = new Point(605, 234);
            button12.Name = "button12";
            button12.Size = new Size(75, 23);
            button12.TabIndex = 41;
            button12.Text = "Get Info";
            button12.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(486, 263);
            label17.Name = "label17";
            label17.Size = new Size(111, 15);
            label17.TabIndex = 42;
            label17.Text = "Network Speed Test";
            // 
            // button13
            // 
            button13.Location = new Point(605, 259);
            button13.Name = "button13";
            button13.Size = new Size(75, 23);
            button13.TabIndex = 43;
            button13.Text = "Test Speed";
            button13.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(486, 288);
            label18.Name = "label18";
            label18.Size = new Size(92, 15);
            label18.TabIndex = 44;
            label18.Text = "Hosts File Editor";
            // 
            // button14
            // 
            button14.Location = new Point(584, 284);
            button14.Name = "button14";
            button14.Size = new Size(75, 23);
            button14.TabIndex = 45;
            button14.Text = "Edit File";
            button14.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(486, 313);
            label19.Name = "label19";
            label19.Size = new Size(169, 15);
            label19.TabIndex = 46;
            label19.Text = "Quick Network Troubleshooter";
            // 
            // button15
            // 
            button15.Location = new Point(661, 309);
            button15.Name = "button15";
            button15.Size = new Size(75, 23);
            button15.TabIndex = 47;
            button15.Text = "Find Issues";
            button15.UseVisualStyleBackColor = true;
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
        private Button SearchForDupedFiles;
        private Label SearchDupedFiles;
        private CheckBox OutputLogs;
        private Button BeginRepairButton;
        private Button CreateSpecsButton;
        private Label CreateFile;
        private Button AdvancedStatsButton;
        private Label AdvancedSystemStats;
        private Button StartOptimizingButton;
        private Label EnterSafeMode;
        private Label EnterBIOS;
        private Button EnterBIOSButton;
        private Button EnterSafeModeButton;
        private Button SaveSettingsButton;
        private CheckBox DarkMode;
        private Button ResetToDefaults;
        private Button QuickRepair;
        private Label LastRepair;
        private Label WelcomeMessage;
        private Label ParagraphAbout;
        private CheckBox CheckWindowsUpdate;
        private CheckBox AdjustPerformanceWindows;
        private CheckBox OptimizePcOnBoot;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button4;
        private Label label8;
        private Button button3;
        private Button button2;
        private Button button6;
        private Label label10;
        private Button button5;
        private Label label9;
        private Label label16;
        private Button button11;
        private Label label15;
        private Button button10;
        private Label label14;
        private Button button9;
        private Label label13;
        private Button button8;
        private Label label12;
        private Button button7;
        private Label label11;
        private Label label17;
        private Button button12;
        private Button button14;
        private Label label18;
        private Button button13;
        private Button button15;
        private Label label19;
    }
}
