namespace PW2SPP
{
    partial class ReadWriteFilesForm
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
            OpenButton = new Button();
            SaveButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(12, 556);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(596, 105);
            OpenButton.TabIndex = 1;
            OpenButton.Text = "Открыть";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(614, 556);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(636, 105);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1238, 538);
            textBox1.TabIndex = 3;
            // 
            // ReadWriteFilesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(textBox1);
            Controls.Add(SaveButton);
            Controls.Add(OpenButton);
            Name = "ReadWriteFilesForm";
            Text = "Read and write files form";
            Load += FormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button OpenButton;
        private Button SaveButton;
        private TextBox textBox1;
    }
}
