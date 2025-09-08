namespace CobaltOS
{
    partial class ScriptRunnerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BatchfileRadioButton = new RadioButton();
            PowershellRadioButton = new RadioButton();
            CodeTextBox = new TextBox();
            RadioButtonsPanel = new Panel();
            CustomScriptFileRadioButton = new RadioButton();
            RunScriptButton = new Button();
            MainTextLabel = new Label();
            OpenFileScriptRunner = new OpenFileDialog();
            OpenFileButton = new Button();
            RadioButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BatchfileRadioButton
            // 
            BatchfileRadioButton.AutoSize = true;
            BatchfileRadioButton.Location = new Point(3, 3);
            BatchfileRadioButton.Name = "BatchfileRadioButton";
            BatchfileRadioButton.Size = new Size(71, 19);
            BatchfileRadioButton.TabIndex = 0;
            BatchfileRadioButton.TabStop = true;
            BatchfileRadioButton.Text = "Batchfile";
            BatchfileRadioButton.UseVisualStyleBackColor = true;
            // 
            // PowershellRadioButton
            // 
            PowershellRadioButton.AutoSize = true;
            PowershellRadioButton.Location = new Point(80, 3);
            PowershellRadioButton.Name = "PowershellRadioButton";
            PowershellRadioButton.Size = new Size(82, 19);
            PowershellRadioButton.TabIndex = 1;
            PowershellRadioButton.TabStop = true;
            PowershellRadioButton.Text = "Powershell";
            PowershellRadioButton.UseVisualStyleBackColor = true;
            // 
            // CodeTextBox
            // 
            CodeTextBox.Location = new Point(271, 13);
            CodeTextBox.Multiline = true;
            CodeTextBox.Name = "CodeTextBox";
            CodeTextBox.PlaceholderText = "Enter code here! Make sure to select the correct scripting language you will be using.";
            CodeTextBox.ScrollBars = ScrollBars.Vertical;
            CodeTextBox.Size = new Size(517, 425);
            CodeTextBox.TabIndex = 3;
            CodeTextBox.WordWrap = false;
            // 
            // RadioButtonsPanel
            // 
            RadioButtonsPanel.Controls.Add(OpenFileButton);
            RadioButtonsPanel.Controls.Add(CustomScriptFileRadioButton);
            RadioButtonsPanel.Controls.Add(RunScriptButton);
            RadioButtonsPanel.Controls.Add(PowershellRadioButton);
            RadioButtonsPanel.Controls.Add(BatchfileRadioButton);
            RadioButtonsPanel.Location = new Point(0, 35);
            RadioButtonsPanel.Name = "RadioButtonsPanel";
            RadioButtonsPanel.Size = new Size(200, 100);
            RadioButtonsPanel.TabIndex = 4;
            // 
            // CustomScriptFileRadioButton
            // 
            CustomScriptFileRadioButton.AutoSize = true;
            CustomScriptFileRadioButton.Location = new Point(3, 28);
            CustomScriptFileRadioButton.Name = "CustomScriptFileRadioButton";
            CustomScriptFileRadioButton.Size = new Size(121, 19);
            CustomScriptFileRadioButton.TabIndex = 6;
            CustomScriptFileRadioButton.TabStop = true;
            CustomScriptFileRadioButton.Text = "Custom Script File";
            CustomScriptFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // RunScriptButton
            // 
            RunScriptButton.Location = new Point(3, 53);
            RunScriptButton.Name = "RunScriptButton";
            RunScriptButton.Size = new Size(75, 23);
            RunScriptButton.TabIndex = 5;
            RunScriptButton.Text = "Run";
            RunScriptButton.UseVisualStyleBackColor = true;
            RunScriptButton.Click += RunScriptButton_Click;
            // 
            // MainTextLabel
            // 
            MainTextLabel.AutoSize = true;
            MainTextLabel.Font = new Font("Segoe UI", 18F);
            MainTextLabel.Location = new Point(0, 0);
            MainTextLabel.Name = "MainTextLabel";
            MainTextLabel.Size = new Size(265, 32);
            MainTextLabel.TabIndex = 6;
            MainTextLabel.Text = "CobaltOS Script Runner";
            // 
            // OpenFileButton
            // 
            OpenFileButton.Location = new Point(84, 53);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new Size(75, 23);
            OpenFileButton.TabIndex = 7;
            OpenFileButton.Text = "Open File";
            OpenFileButton.UseVisualStyleBackColor = true;
            OpenFileButton.Click += OpenFileButton_Click;
            // 
            // ScriptRunnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainTextLabel);
            Controls.Add(RadioButtonsPanel);
            Controls.Add(CodeTextBox);
            Name = "ScriptRunnerForm";
            Text = "ScriptRunnerForm";
            RadioButtonsPanel.ResumeLayout(false);
            RadioButtonsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton BatchfileRadioButton;
        private RadioButton PowershellRadioButton;
        private TextBox CodeTextBox;
        private Panel RadioButtonsPanel;
        private Button RunScriptButton;
        private RadioButton CustomScriptFileRadioButton;
        private Label MainTextLabel;
        private OpenFileDialog OpenFileScriptRunner;
        private Button OpenFileButton;
    }
}