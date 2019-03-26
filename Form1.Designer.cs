namespace Creation
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageForm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSelect = new System.Windows.Forms.TextBox();
            this.textSave = new System.Windows.Forms.TextBox();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonreSave = new System.Windows.Forms.Button();
            this.buttonBalance = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkDark = new System.Windows.Forms.CheckBox();
            this.checkLight = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(447, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageForm
            // 
            this.imageForm.FormattingEnabled = true;
            this.imageForm.Location = new System.Drawing.Point(51, 144);
            this.imageForm.Name = "imageForm";
            this.imageForm.Size = new System.Drawing.Size(94, 24);
            this.imageForm.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Image Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Width";
            // 
            // textWidth
            // 
            this.textWidth.Location = new System.Drawing.Point(189, 144);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(90, 22);
            this.textWidth.TabIndex = 14;
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(295, 144);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(90, 22);
            this.textHeight.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Height";
            // 
            // textSelect
            // 
            this.textSelect.Location = new System.Drawing.Point(160, 30);
            this.textSelect.Name = "textSelect";
            this.textSelect.Size = new System.Drawing.Size(281, 22);
            this.textSelect.TabIndex = 17;
            // 
            // textSave
            // 
            this.textSave.Location = new System.Drawing.Point(160, 82);
            this.textSave.Name = "textSave";
            this.textSave.Size = new System.Drawing.Size(281, 22);
            this.textSave.TabIndex = 18;
            // 
            // buttonResize
            // 
            this.buttonResize.Location = new System.Drawing.Point(219, 172);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(133, 40);
            this.buttonResize.TabIndex = 19;
            this.buttonResize.Text = "Resize";
            this.buttonResize.UseVisualStyleBackColor = true;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 64);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(133, 40);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save Folder";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(9, 12);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(133, 40);
            this.buttonSelect.TabIndex = 21;
            this.buttonSelect.Text = "Select ";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonreSave
            // 
            this.buttonreSave.Location = new System.Drawing.Point(219, 234);
            this.buttonreSave.Name = "buttonreSave";
            this.buttonreSave.Size = new System.Drawing.Size(133, 40);
            this.buttonreSave.TabIndex = 22;
            this.buttonreSave.Text = "Save";
            this.buttonreSave.UseVisualStyleBackColor = true;
            this.buttonreSave.Click += new System.EventHandler(this.buttonreSave_Click);
            // 
            // buttonBalance
            // 
            this.buttonBalance.Enabled = false;
            this.buttonBalance.Location = new System.Drawing.Point(12, 255);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(133, 40);
            this.buttonBalance.TabIndex = 23;
            this.buttonBalance.Text = "Balance";
            this.buttonBalance.UseVisualStyleBackColor = true;
            this.buttonBalance.Click += new System.EventHandler(this.buttonBalance_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Image";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 174);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 21);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Balance Open";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkDark
            // 
            this.checkDark.AutoSize = true;
            this.checkDark.Enabled = false;
            this.checkDark.Location = new System.Drawing.Point(22, 201);
            this.checkDark.Name = "checkDark";
            this.checkDark.Size = new System.Drawing.Size(97, 21);
            this.checkDark.TabIndex = 27;
            this.checkDark.Text = "Dark Color";
            this.checkDark.UseVisualStyleBackColor = true;
            this.checkDark.CheckedChanged += new System.EventHandler(this.checkDark_CheckedChanged);
            // 
            // checkLight
            // 
            this.checkLight.AutoSize = true;
            this.checkLight.Enabled = false;
            this.checkLight.Location = new System.Drawing.Point(22, 228);
            this.checkLight.Name = "checkLight";
            this.checkLight.Size = new System.Drawing.Size(98, 21);
            this.checkLight.TabIndex = 28;
            this.checkLight.Text = "Light Color";
            this.checkLight.UseVisualStyleBackColor = true;
            this.checkLight.CheckedChanged += new System.EventHandler(this.checkLight_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(831, 320);
            this.Controls.Add(this.checkLight);
            this.Controls.Add(this.checkDark);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBalance);
            this.Controls.Add(this.buttonreSave);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonResize);
            this.Controls.Add(this.textSave);
            this.Controls.Add(this.textSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.textWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageForm);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ysa™";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox imageForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSelect;
        private System.Windows.Forms.TextBox textSave;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonreSave;
        private System.Windows.Forms.Button buttonBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkDark;
        private System.Windows.Forms.CheckBox checkLight;
    }
}

