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
            // EnterSafeModeButton
            // 
            EnterSafeModeButton.Location = new Point(124, 121);
            EnterSafeModeButton.Name = "EnterSafeModeButton";
            EnterSafeModeButton.Size = new Size(75, 23);
            EnterSafeModeButton.TabIndex = 13;
            EnterSafeModeButton.Text = "Enter";
            EnterSafeModeButton.UseVisualStyleBackColor = true;
            EnterSafeModeButton.Click += EnterSafeModeButton_Click;
            // 
            // EnterBIOSButton
            // 
            EnterBIOSButton.Location = new Point(93, 96);
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
            EnterSafeMode.Location = new Point(25, 125);
            EnterSafeMode.Name = "EnterSafeMode";
            EnterSafeMode.Size = new Size(93, 15);
            EnterSafeMode.TabIndex = 11;
            EnterSafeMode.Text = "Enter Safe Mode";
            // 
            // EnterBIOS
            // 
            EnterBIOS.AutoSize = true;
            EnterBIOS.Location = new Point(25, 100);
            EnterBIOS.Name = "EnterBIOS";
            EnterBIOS.Size = new Size(62, 15);
            EnterBIOS.TabIndex = 10;
            EnterBIOS.Text = "Enter BIOS";
            // 
            // CreateSpecsButton
            // 
            CreateSpecsButton.Location = new Point(207, 71);
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
            CreateFile.Location = new Point(25, 75);
            CreateFile.Name = "CreateFile";
            CreateFile.Size = new Size(176, 15);
            CreateFile.TabIndex = 8;
            CreateFile.Text = "Create a .txt file of System Specs";
            // 
            // AdvancedStatsButton
            // 
            AdvancedStatsButton.Location = new Point(160, 46);
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
            AdvancedSystemStats.Location = new Point(25, 50);
            AdvancedSystemStats.Name = "AdvancedSystemStats";
            AdvancedSystemStats.Size = new Size(129, 15);
            AdvancedSystemStats.TabIndex = 6;
            AdvancedSystemStats.Text = "Advanced System Stats";
            // 
            // SearchForDupedFiles
            // 
            SearchForDupedFiles.Location = new Point(170, 21);
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
            SearchDupedFiles.Location = new Point(25, 25);
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
    }
}
