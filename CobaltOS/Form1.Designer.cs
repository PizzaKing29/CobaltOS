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
            button1 = new Button();
            LastRepair = new Label();
            SystemHealth = new Label();
            label3 = new Label();
            Optimization = new TabPage();
            StartOptimizingButton = new Button();
            FasterDNS = new CheckBox();
            TempFileCleaner = new CheckBox();
            GamingOptimization = new CheckBox();
            Repair = new TabPage();
            OutputLogs = new CheckBox();
            BeginRepairButton = new Button();
            BasicCommandRepairs = new CheckBox();
            MalwareScan = new CheckBox();
            EvaluateServices = new CheckBox();
            FindNetworkSeviceIssues = new CheckBox();
            CheckPCComponentsHealth = new CheckBox();
            BSODRepair = new CheckBox();
            Utilities = new TabPage();
            SleepPC = new Button();
            RestartPC = new Button();
            ShutdownPC = new Button();
            label2 = new Label();
            EnterSafeModeButton = new Button();
            EnterBIOSButton = new Button();
            EnterSafeMode = new Label();
            EnterBIOS = new Label();
            CreateSpecsButton = new Button();
            CreateFile = new Label();
            AdvancedStatsButton = new Button();
            AdvancedSystemStats = new Label();
            CreateRestoreButton = new Button();
            CreateRestorePoint = new Label();
            SearchForDupedFiles = new Button();
            label1 = new Label();
            EnableOrDisableDefender = new Label();
            EnableOrDisableDefenderButton = new Button();
            Settings = new TabPage();
            ResetToDefaults = new Button();
            SaveSettingsButton = new Button();
            DarkMode = new CheckBox();
            OptimizeOnBoot = new CheckBox();
            label4 = new Label();
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
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(LastRepair);
            tabPage1.Controls.Add(SystemHealth);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 424);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(25, 225);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 3;
            button1.Text = "Quick Repair";
            button1.UseVisualStyleBackColor = true;
            // 
            // LastRepair
            // 
            LastRepair.AutoSize = true;
            LastRepair.Location = new Point(25, 200);
            LastRepair.Name = "LastRepair";
            LastRepair.Size = new Size(136, 15);
            LastRepair.TabIndex = 2;
            LastRepair.Text = "Last Repair: 4 Hours Ago";
            // 
            // SystemHealth
            // 
            SystemHealth.AutoSize = true;
            SystemHealth.Location = new Point(25, 175);
            SystemHealth.Name = "SystemHealth";
            SystemHealth.Size = new Size(180, 15);
            SystemHealth.TabIndex = 1;
            SystemHealth.Text = "Overall System Health: Unknown";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 35F);
            label3.Location = new Point(150, 10);
            label3.Name = "label3";
            label3.Size = new Size(499, 62);
            label3.TabIndex = 0;
            label3.Text = "Welcome to CobaltOS!";
            // 
            // Optimization
            // 
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
            // StartOptimizingButton
            // 
            StartOptimizingButton.Location = new Point(25, 125);
            StartOptimizingButton.Name = "StartOptimizingButton";
            StartOptimizingButton.Size = new Size(75, 23);
            StartOptimizingButton.TabIndex = 3;
            StartOptimizingButton.Text = "Start";
            StartOptimizingButton.UseVisualStyleBackColor = true;
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
            Repair.Controls.Add(OutputLogs);
            Repair.Controls.Add(BeginRepairButton);
            Repair.Controls.Add(BasicCommandRepairs);
            Repair.Controls.Add(MalwareScan);
            Repair.Controls.Add(EvaluateServices);
            Repair.Controls.Add(FindNetworkSeviceIssues);
            Repair.Controls.Add(CheckPCComponentsHealth);
            Repair.Controls.Add(BSODRepair);
            Repair.Location = new Point(4, 24);
            Repair.Name = "Repair";
            Repair.Padding = new Padding(3);
            Repair.Size = new Size(795, 424);
            Repair.TabIndex = 2;
            Repair.Text = "Repair";
            Repair.UseVisualStyleBackColor = true;
            // 
            // OutputLogs
            // 
            OutputLogs.AutoSize = true;
            OutputLogs.Location = new Point(106, 203);
            OutputLogs.Name = "OutputLogs";
            OutputLogs.Size = new Size(150, 19);
            OutputLogs.TabIndex = 7;
            OutputLogs.Text = "Output logs as a .txt file";
            OutputLogs.UseVisualStyleBackColor = true;
            // 
            // BeginRepairButton
            // 
            BeginRepairButton.Location = new Point(25, 200);
            BeginRepairButton.Name = "BeginRepairButton";
            BeginRepairButton.Size = new Size(75, 23);
            BeginRepairButton.TabIndex = 6;
            BeginRepairButton.Text = "Begin";
            BeginRepairButton.UseVisualStyleBackColor = true;
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
            MalwareScan.Size = new Size(99, 19);
            MalwareScan.TabIndex = 4;
            MalwareScan.Text = "Malware Scan";
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
            // CheckPCComponentsHealth
            // 
            CheckPCComponentsHealth.AutoSize = true;
            CheckPCComponentsHealth.Location = new Point(25, 50);
            CheckPCComponentsHealth.Name = "CheckPCComponentsHealth";
            CheckPCComponentsHealth.Size = new Size(187, 19);
            CheckPCComponentsHealth.TabIndex = 1;
            CheckPCComponentsHealth.Text = "Check PC Components Health";
            CheckPCComponentsHealth.UseVisualStyleBackColor = true;
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
            Utilities.Controls.Add(SleepPC);
            Utilities.Controls.Add(RestartPC);
            Utilities.Controls.Add(ShutdownPC);
            Utilities.Controls.Add(label2);
            Utilities.Controls.Add(EnterSafeModeButton);
            Utilities.Controls.Add(EnterBIOSButton);
            Utilities.Controls.Add(EnterSafeMode);
            Utilities.Controls.Add(EnterBIOS);
            Utilities.Controls.Add(CreateSpecsButton);
            Utilities.Controls.Add(CreateFile);
            Utilities.Controls.Add(AdvancedStatsButton);
            Utilities.Controls.Add(AdvancedSystemStats);
            Utilities.Controls.Add(CreateRestoreButton);
            Utilities.Controls.Add(CreateRestorePoint);
            Utilities.Controls.Add(SearchForDupedFiles);
            Utilities.Controls.Add(label1);
            Utilities.Controls.Add(EnableOrDisableDefender);
            Utilities.Controls.Add(EnableOrDisableDefenderButton);
            Utilities.Location = new Point(4, 24);
            Utilities.Name = "Utilities";
            Utilities.Padding = new Padding(3);
            Utilities.Size = new Size(795, 424);
            Utilities.TabIndex = 3;
            Utilities.Text = "Utilities";
            Utilities.UseVisualStyleBackColor = true;
            // 
            // SleepPC
            // 
            SleepPC.Location = new Point(371, 196);
            SleepPC.Name = "SleepPC";
            SleepPC.Size = new Size(75, 23);
            SleepPC.TabIndex = 17;
            SleepPC.Text = "Sleep";
            SleepPC.UseVisualStyleBackColor = true;
            // 
            // RestartPC
            // 
            RestartPC.Location = new Point(290, 196);
            RestartPC.Name = "RestartPC";
            RestartPC.Size = new Size(75, 23);
            RestartPC.TabIndex = 16;
            RestartPC.Text = "Restart";
            RestartPC.UseVisualStyleBackColor = true;
            // 
            // ShutdownPC
            // 
            ShutdownPC.Location = new Point(209, 196);
            ShutdownPC.Name = "ShutdownPC";
            ShutdownPC.Size = new Size(75, 23);
            ShutdownPC.TabIndex = 15;
            ShutdownPC.Text = "Shutdown";
            ShutdownPC.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 200);
            label2.Name = "label2";
            label2.Size = new Size(178, 15);
            label2.TabIndex = 14;
            label2.Text = "Quick 1 Click PC Power Options:";
            // 
            // EnterSafeModeButton
            // 
            EnterSafeModeButton.Location = new Point(124, 171);
            EnterSafeModeButton.Name = "EnterSafeModeButton";
            EnterSafeModeButton.Size = new Size(75, 23);
            EnterSafeModeButton.TabIndex = 13;
            EnterSafeModeButton.Text = "Enter";
            EnterSafeModeButton.UseVisualStyleBackColor = true;
            // 
            // EnterBIOSButton
            // 
            EnterBIOSButton.Location = new Point(93, 146);
            EnterBIOSButton.Name = "EnterBIOSButton";
            EnterBIOSButton.Size = new Size(75, 23);
            EnterBIOSButton.TabIndex = 12;
            EnterBIOSButton.Text = "Enter BIOS";
            EnterBIOSButton.UseVisualStyleBackColor = true;
            // 
            // EnterSafeMode
            // 
            EnterSafeMode.AutoSize = true;
            EnterSafeMode.Location = new Point(25, 175);
            EnterSafeMode.Name = "EnterSafeMode";
            EnterSafeMode.Size = new Size(93, 15);
            EnterSafeMode.TabIndex = 11;
            EnterSafeMode.Text = "Enter Safe Mode";
            // 
            // EnterBIOS
            // 
            EnterBIOS.AutoSize = true;
            EnterBIOS.Location = new Point(25, 150);
            EnterBIOS.Name = "EnterBIOS";
            EnterBIOS.Size = new Size(62, 15);
            EnterBIOS.TabIndex = 10;
            EnterBIOS.Text = "Enter BIOS";
            // 
            // CreateSpecsButton
            // 
            CreateSpecsButton.Location = new Point(207, 121);
            CreateSpecsButton.Name = "CreateSpecsButton";
            CreateSpecsButton.Size = new Size(75, 23);
            CreateSpecsButton.TabIndex = 9;
            CreateSpecsButton.Text = "Create";
            CreateSpecsButton.UseVisualStyleBackColor = true;
            // 
            // CreateFile
            // 
            CreateFile.AutoSize = true;
            CreateFile.Location = new Point(25, 125);
            CreateFile.Name = "CreateFile";
            CreateFile.Size = new Size(176, 15);
            CreateFile.TabIndex = 8;
            CreateFile.Text = "Create a .txt file of System Specs";
            // 
            // AdvancedStatsButton
            // 
            AdvancedStatsButton.Location = new Point(160, 96);
            AdvancedStatsButton.Name = "AdvancedStatsButton";
            AdvancedStatsButton.Size = new Size(75, 23);
            AdvancedStatsButton.TabIndex = 7;
            AdvancedStatsButton.Text = "Show";
            AdvancedStatsButton.UseVisualStyleBackColor = true;
            // 
            // AdvancedSystemStats
            // 
            AdvancedSystemStats.AutoSize = true;
            AdvancedSystemStats.Location = new Point(25, 100);
            AdvancedSystemStats.Name = "AdvancedSystemStats";
            AdvancedSystemStats.Size = new Size(129, 15);
            AdvancedSystemStats.TabIndex = 6;
            AdvancedSystemStats.Text = "Advanced System Stats";
            // 
            // CreateRestoreButton
            // 
            CreateRestoreButton.Location = new Point(186, 71);
            CreateRestoreButton.Name = "CreateRestoreButton";
            CreateRestoreButton.Size = new Size(75, 23);
            CreateRestoreButton.TabIndex = 5;
            CreateRestoreButton.Text = "Create";
            CreateRestoreButton.UseVisualStyleBackColor = true;
            // 
            // CreateRestorePoint
            // 
            CreateRestorePoint.AutoSize = true;
            CreateRestorePoint.Location = new Point(25, 75);
            CreateRestorePoint.Name = "CreateRestorePoint";
            CreateRestorePoint.Size = new Size(155, 15);
            CreateRestorePoint.TabIndex = 4;
            CreateRestorePoint.Text = "Create System Restore Point";
            // 
            // SearchForDupedFiles
            // 
            SearchForDupedFiles.Location = new Point(170, 46);
            SearchForDupedFiles.Name = "SearchForDupedFiles";
            SearchForDupedFiles.Size = new Size(75, 23);
            SearchForDupedFiles.TabIndex = 3;
            SearchForDupedFiles.Text = "Search";
            SearchForDupedFiles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 50);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 2;
            label1.Text = "Search for Duplicate Files";
            // 
            // EnableOrDisableDefender
            // 
            EnableOrDisableDefender.AutoSize = true;
            EnableOrDisableDefender.Location = new Point(25, 25);
            EnableOrDisableDefender.Name = "EnableOrDisableDefender";
            EnableOrDisableDefender.Size = new Size(194, 15);
            EnableOrDisableDefender.TabIndex = 1;
            EnableOrDisableDefender.Text = "Enable / Disable Windows Defender";
            // 
            // EnableOrDisableDefenderButton
            // 
            EnableOrDisableDefenderButton.Location = new Point(225, 21);
            EnableOrDisableDefenderButton.Name = "EnableOrDisableDefenderButton";
            EnableOrDisableDefenderButton.Size = new Size(75, 23);
            EnableOrDisableDefenderButton.TabIndex = 0;
            EnableOrDisableDefenderButton.Text = "Disable";
            EnableOrDisableDefenderButton.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            Settings.Controls.Add(ResetToDefaults);
            Settings.Controls.Add(SaveSettingsButton);
            Settings.Controls.Add(DarkMode);
            Settings.Controls.Add(OptimizeOnBoot);
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
            ResetToDefaults.Location = new Point(106, 75);
            ResetToDefaults.Name = "ResetToDefaults";
            ResetToDefaults.Size = new Size(75, 23);
            ResetToDefaults.TabIndex = 3;
            ResetToDefaults.Text = "Reset";
            ResetToDefaults.UseVisualStyleBackColor = true;
            // 
            // SaveSettingsButton
            // 
            SaveSettingsButton.Location = new Point(25, 75);
            SaveSettingsButton.Name = "SaveSettingsButton";
            SaveSettingsButton.Size = new Size(75, 23);
            SaveSettingsButton.TabIndex = 2;
            SaveSettingsButton.Text = "Save";
            SaveSettingsButton.UseVisualStyleBackColor = true;
            // 
            // DarkMode
            // 
            DarkMode.AutoSize = true;
            DarkMode.Location = new Point(25, 50);
            DarkMode.Name = "DarkMode";
            DarkMode.Size = new Size(84, 19);
            DarkMode.TabIndex = 1;
            DarkMode.Text = "Dark Mode";
            DarkMode.UseVisualStyleBackColor = true;
            // 
            // OptimizeOnBoot
            // 
            OptimizeOnBoot.AutoSize = true;
            OptimizeOnBoot.Location = new Point(25, 25);
            OptimizeOnBoot.Name = "OptimizeOnBoot";
            OptimizeOnBoot.Size = new Size(137, 19);
            OptimizeOnBoot.TabIndex = 0;
            OptimizeOnBoot.Text = "Optimize PC on boot";
            OptimizeOnBoot.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(25, 100);
            label4.Name = "label4";
            label4.Size = new Size(377, 50);
            label4.TabIndex = 4;
            label4.Text = resources.GetString("label4.Text");
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
        private CheckBox CheckPCComponentsHealth;
        private CheckBox BSODRepair;
        private CheckBox BasicCommandRepairs;
        private CheckBox MalwareScan;
        private Button SearchForDupedFiles;
        private Label label1;
        private Label EnableOrDisableDefender;
        private Button EnableOrDisableDefenderButton;
        private CheckBox OutputLogs;
        private Button BeginRepairButton;
        private Button CreateSpecsButton;
        private Label CreateFile;
        private Button AdvancedStatsButton;
        private Label AdvancedSystemStats;
        private Button CreateRestoreButton;
        private Label CreateRestorePoint;
        private Button StartOptimizingButton;
        private Label EnterSafeMode;
        private Label EnterBIOS;
        private CheckBox OptimizeOnBoot;
        private Button EnterBIOSButton;
        private Button EnterSafeModeButton;
        private Button SleepPC;
        private Button RestartPC;
        private Button ShutdownPC;
        private Label label2;
        private Button SaveSettingsButton;
        private CheckBox DarkMode;
        private Button ResetToDefaults;
        private Button button1;
        private Label LastRepair;
        private Label SystemHealth;
        private Label label3;
        private Label label4;
    }
}
