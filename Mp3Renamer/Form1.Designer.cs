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
            startRenamingButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            folderPicker = new FolderBrowserDialog();
            folderPickerButton = new Button();
            folderPathTextBox = new TextBox();
            label5 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // startRenamingButton
            // 
            startRenamingButton.Enabled = false;
            startRenamingButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startRenamingButton.Location = new Point(604, 370);
            startRenamingButton.Name = "startRenamingButton";
            startRenamingButton.Size = new Size(155, 44);
            startRenamingButton.TabIndex = 0;
            startRenamingButton.Text = "Start renaming!";
            startRenamingButton.UseVisualStyleBackColor = true;
            startRenamingButton.Click += startRenamingButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 31);
            label1.Name = "label1";
            label1.Size = new Size(208, 21);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Mp3Renamer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 108);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(567, 40);
            label2.TabIndex = 2;
            label2.Text = "This application is for those who keep offline music files and like to keep the format \r\nof the title consistent across their entire music collection.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 394);
            label3.Name = "label3";
            label3.Size = new Size(379, 20);
            label3.TabIndex = 3;
            label3.Text = "Note: music files without ID3 tags will not be processed.";
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
            folderPicker.Description = "Select a folder";
            folderPicker.RootFolder = Environment.SpecialFolder.MyMusic;
            // 
            // folderPickerButton
            // 
            folderPickerButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            folderPickerButton.Location = new Point(520, 296);
            folderPickerButton.Name = "folderPickerButton";
            folderPickerButton.Size = new Size(41, 29);
            folderPickerButton.TabIndex = 5;
            folderPickerButton.Text = "...";
            folderPickerButton.UseVisualStyleBackColor = true;
            folderPickerButton.Click += folderPickerButton_Click;
            // 
            // folderPathTextBox
            // 
            folderPathTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            folderPathTextBox.Location = new Point(43, 296);
            folderPathTextBox.Name = "folderPathTextBox";
            folderPathTextBox.ReadOnly = true;
            folderPathTextBox.Size = new Size(472, 27);
            folderPathTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 272);
            label5.Name = "label5";
            label5.Size = new Size(313, 20);
            label5.TabIndex = 7;
            label5.Text = "Select the folder that contains your music files";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 197);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(604, 20);
            label7.TabIndex = 9;
            label7.Text = "The format of each file name will changed from \"<title> - <artist>\" to \"<artist> - <title>\".\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(635, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 117);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(folderPathTextBox);
            Controls.Add(folderPickerButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(startRenamingButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Mp3 Renamer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startRenamingButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FolderBrowserDialog folderPicker;
        private Button folderPickerButton;
        private TextBox folderPathTextBox;
        private Label label5;
        private Label label7;
        private PictureBox pictureBox1;
    }
}
