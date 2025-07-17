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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 52);
            label1.TabIndex = 0;
            label1.Text = "To proceed it is highly suggested to create a system restore point, would you like to?";
            // 
            // button1
            // 
            button1.Location = new Point(12, 76);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Yes";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(147, 76);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "No ⚠️";
            button2.UseVisualStyleBackColor = true;
            // 
            // CreateRestorePoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 111);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "CreateRestorePoint";
            Text = "CreateRestorePoint";
            Load += CreateRestorePoint_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}