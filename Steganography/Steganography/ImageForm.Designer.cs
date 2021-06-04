
namespace Steganography
{
    partial class ImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.texttoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.texttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptCheckBox = new System.Windows.Forms.CheckBox();
            this.hideButton = new System.Windows.Forms.Button();
            this.extractButton = new System.Windows.Forms.Button();
            this.notesLabel = new System.Windows.Forms.Label();
            this.EmailButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filetoolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(100, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(100, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filetoolStripMenuItem
            // 
            this.filetoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.filetoolStripMenuItem.Name = "filetoolStripMenuItem";
            this.filetoolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.filetoolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageStripMenuItem1,
            this.texttoolStripMenuItem1});
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            // 
            // imageStripMenuItem1
            // 
            this.imageStripMenuItem1.Name = "imageStripMenuItem1";
            this.imageStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.imageStripMenuItem1.Text = "Image";
            this.imageStripMenuItem1.Click += new System.EventHandler(this.imageToolStripMenuItem1_Click);
            // 
            // texttoolStripMenuItem1
            // 
            this.texttoolStripMenuItem1.DoubleClickEnabled = true;
            this.texttoolStripMenuItem1.Name = "texttoolStripMenuItem1";
            this.texttoolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.texttoolStripMenuItem1.Text = "Text";
            this.texttoolStripMenuItem1.Click += new System.EventHandler(this.textToolStripMenuItem1_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagetoolStripMenuItem,
            this.texttoolStripMenuItem});
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            // 
            // imagetoolStripMenuItem
            // 
            this.imagetoolStripMenuItem.Name = "imagetoolStripMenuItem";
            this.imagetoolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.imagetoolStripMenuItem.Text = "Image";
            this.imagetoolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // texttoolStripMenuItem
            // 
            this.texttoolStripMenuItem.Name = "texttoolStripMenuItem";
            this.texttoolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.texttoolStripMenuItem.Text = "Text";
            this.texttoolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imagePictureBox.Image")));
            this.imagePictureBox.Location = new System.Drawing.Point(13, 27);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(369, 173);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 1;
            this.imagePictureBox.TabStop = false;
            // 
            // dataTextBox
            // 
            this.dataTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataTextBox.Location = new System.Drawing.Point(12, 206);
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTextBox.Size = new System.Drawing.Size(369, 117);
            this.dataTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.encryptCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(13, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(192, 20);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(157, 23);
            this.passwordTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // encryptCheckBox
            // 
            this.encryptCheckBox.AutoSize = true;
            this.encryptCheckBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.encryptCheckBox.Location = new System.Drawing.Point(3, 19);
            this.encryptCheckBox.Name = "encryptCheckBox";
            this.encryptCheckBox.Size = new System.Drawing.Size(96, 23);
            this.encryptCheckBox.TabIndex = 0;
            this.encryptCheckBox.Text = "Encrypted";
            this.encryptCheckBox.UseVisualStyleBackColor = true;
            // 
            // hideButton
            // 
            this.hideButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hideButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hideButton.Image = ((System.Drawing.Image)(resources.GetObject("hideButton.Image")));
            this.hideButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hideButton.Location = new System.Drawing.Point(16, 396);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(161, 42);
            this.hideButton.TabIndex = 4;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = false;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // extractButton
            // 
            this.extractButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.extractButton.Image = ((System.Drawing.Image)(resources.GetObject("extractButton.Image")));
            this.extractButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.extractButton.Location = new System.Drawing.Point(201, 396);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(161, 42);
            this.extractButton.TabIndex = 5;
            this.extractButton.Text = "Extract";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notesLabel.Location = new System.Drawing.Point(12, 458);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(49, 19);
            this.notesLabel.TabIndex = 6;
            this.notesLabel.Text = "Notes:";
            // 
            // EmailButton
            // 
            this.EmailButton.CausesValidation = false;
            this.EmailButton.FlatAppearance.BorderSize = 0;
            this.EmailButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EmailButton.Location = new System.Drawing.Point(271, 1);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(111, 23);
            this.EmailButton.TabIndex = 7;
            this.EmailButton.Text = "Email";
            this.EmailButton.UseVisualStyleBackColor = false;
            this.EmailButton.Click += new System.EventHandler(this.EmailButton_Click);
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 486);
            this.Controls.Add(this.EmailButton);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ImageForm";
            this.Text = "SteganoForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem texttoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem texttoolStripMenuItem;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox encryptCheckBox;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Button EmailButton;
    }
}