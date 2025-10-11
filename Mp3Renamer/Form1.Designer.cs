namespace Mp3Renamer
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            folderPicker = new FolderBrowserDialog();
            folderPickerButton = new Button();
            folderPathTextBox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(606, 371);
            button1.Name = "button1";
            button1.Size = new Size(155, 44);
            button1.TabIndex = 0;
            button1.Text = "Start renaming!";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 50);
            label1.Name = "label1";
            label1.Size = new Size(208, 21);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Mp3Renamer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 98);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(589, 42);
            label2.TabIndex = 2;
            label2.Text = "This application is for those who keep offline music files and like to keep the format \r\nof the title consistent across their entire music collection.";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 321);
            label3.Name = "label3";
            label3.Size = new Size(545, 21);
            label3.TabIndex = 3;
            label3.Text = "Note: for the application to work, ID3 tags must be present on each music file.\r\n";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 186);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 4;
            // 
            // folderPicker
            // 
            folderPicker.Description = "Select the folder containing the music files";
            folderPicker.SelectedPath = "C:\\";
            // 
            // folderPickerButton
            // 
            folderPickerButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            folderPickerButton.Location = new Point(519, 210);
            folderPickerButton.Name = "folderPickerButton";
            folderPickerButton.Size = new Size(41, 29);
            folderPickerButton.TabIndex = 5;
            folderPickerButton.Text = "...";
            folderPickerButton.UseVisualStyleBackColor = true;
            folderPickerButton.Click += folderPickerButton_Click;
            // 
            // folderPathTextBox
            // 
            folderPathTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            folderPathTextBox.Location = new Point(42, 210);
            folderPathTextBox.Name = "folderPathTextBox";
            folderPathTextBox.ReadOnly = true;
            folderPathTextBox.Size = new Size(472, 29);
            folderPathTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 186);
            label5.Name = "label5";
            label5.Size = new Size(328, 21);
            label5.TabIndex = 7;
            label5.Text = "Select the folder that contains your music files";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(folderPathTextBox);
            Controls.Add(folderPickerButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Mp3 Renamer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FolderBrowserDialog folderPicker;
        private Button folderPickerButton;
        private TextBox folderPathTextBox;
        private Label label5;
    }
}
