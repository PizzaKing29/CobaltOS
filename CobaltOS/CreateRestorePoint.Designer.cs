namespace CobaltOS
{
    partial class CreateRestorePoint
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
            WarningMessage = new Label();
            YesButton = new Button();
            NoButton = new Button();
            SuspendLayout();
            // 
            // WarningMessage
            // 
            WarningMessage.Location = new Point(3, 9);
            WarningMessage.Name = "WarningMessage";
            WarningMessage.Size = new Size(228, 52);
            WarningMessage.TabIndex = 0;
            WarningMessage.Text = "To proceed it is highly suggested to create a system restore point, would you like to?";
            // 
            // YesButton
            // 
            YesButton.Location = new Point(12, 76);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(75, 23);
            YesButton.TabIndex = 1;
            YesButton.Text = "Yes";
            YesButton.UseVisualStyleBackColor = true;
            YesButton.Click += YesButton_Click;
            // 
            // NoButton
            // 
            NoButton.Location = new Point(147, 76);
            NoButton.Name = "NoButton";
            NoButton.Size = new Size(75, 23);
            NoButton.TabIndex = 2;
            NoButton.Text = "No ⚠️";
            NoButton.UseVisualStyleBackColor = true;
            NoButton.Click += NoButton_Click;
            // 
            // CreateRestorePoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 111);
            Controls.Add(NoButton);
            Controls.Add(YesButton);
            Controls.Add(WarningMessage);
            Name = "CreateRestorePoint";
            Text = "CreateRestorePoint";
            Load += CreateRestorePoint_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label WarningMessage;
        private Button YesButton;
        private Button NoButton;
    }
}