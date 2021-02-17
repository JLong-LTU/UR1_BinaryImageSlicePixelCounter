namespace BinaryImageSlicePixelCounter
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
            this.origImagePictureBox = new System.Windows.Forms.PictureBox();
            this.binaryImagePictureBox = new System.Windows.Forms.PictureBox();
            this.thresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.lfPixelCtLbl = new System.Windows.Forms.Label();
            this.lPixelCtLbl = new System.Windows.Forms.Label();
            this.cPixelCtLbl = new System.Windows.Forms.Label();
            this.rPixelCtLbl = new System.Windows.Forms.Label();
            this.rfPixelCtLbl = new System.Windows.Forms.Label();
            this.bonusFeaturesEnabledCBox = new System.Windows.Forms.CheckBox();
            this.nextInstructionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.origImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // origImagePictureBox
            // 
            this.origImagePictureBox.Location = new System.Drawing.Point(13, 13);
            this.origImagePictureBox.Name = "origImagePictureBox";
            this.origImagePictureBox.Size = new System.Drawing.Size(370, 324);
            this.origImagePictureBox.TabIndex = 0;
            this.origImagePictureBox.TabStop = false;
            // 
            // binaryImagePictureBox
            // 
            this.binaryImagePictureBox.Location = new System.Drawing.Point(409, 13);
            this.binaryImagePictureBox.Name = "binaryImagePictureBox";
            this.binaryImagePictureBox.Size = new System.Drawing.Size(379, 324);
            this.binaryImagePictureBox.TabIndex = 1;
            this.binaryImagePictureBox.TabStop = false;
            // 
            // thresholdTrackBar
            // 
            this.thresholdTrackBar.Location = new System.Drawing.Point(13, 382);
            this.thresholdTrackBar.Maximum = 255;
            this.thresholdTrackBar.Name = "thresholdTrackBar";
            this.thresholdTrackBar.Size = new System.Drawing.Size(775, 56);
            this.thresholdTrackBar.TabIndex = 2;
            this.thresholdTrackBar.Scroll += new System.EventHandler(this.thresholdTrackBar_Scroll);
            // 
            // lfPixelCtLbl
            // 
            this.lfPixelCtLbl.AutoSize = true;
            this.lfPixelCtLbl.Location = new System.Drawing.Point(431, 340);
            this.lfPixelCtLbl.Name = "lfPixelCtLbl";
            this.lfPixelCtLbl.Size = new System.Drawing.Size(24, 17);
            this.lfPixelCtLbl.TabIndex = 3;
            this.lfPixelCtLbl.Text = "LF";
            this.lfPixelCtLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lPixelCtLbl
            // 
            this.lPixelCtLbl.AutoSize = true;
            this.lPixelCtLbl.Location = new System.Drawing.Point(514, 340);
            this.lPixelCtLbl.Name = "lPixelCtLbl";
            this.lPixelCtLbl.Size = new System.Drawing.Size(16, 17);
            this.lPixelCtLbl.TabIndex = 4;
            this.lPixelCtLbl.Text = "L";
            this.lPixelCtLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cPixelCtLbl
            // 
            this.cPixelCtLbl.AutoSize = true;
            this.cPixelCtLbl.Location = new System.Drawing.Point(589, 340);
            this.cPixelCtLbl.Name = "cPixelCtLbl";
            this.cPixelCtLbl.Size = new System.Drawing.Size(17, 17);
            this.cPixelCtLbl.TabIndex = 5;
            this.cPixelCtLbl.Text = "C";
            this.cPixelCtLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rPixelCtLbl
            // 
            this.rPixelCtLbl.AutoSize = true;
            this.rPixelCtLbl.Location = new System.Drawing.Point(656, 340);
            this.rPixelCtLbl.Name = "rPixelCtLbl";
            this.rPixelCtLbl.Size = new System.Drawing.Size(18, 17);
            this.rPixelCtLbl.TabIndex = 6;
            this.rPixelCtLbl.Text = "R";
            this.rPixelCtLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rfPixelCtLbl
            // 
            this.rfPixelCtLbl.AutoSize = true;
            this.rfPixelCtLbl.Location = new System.Drawing.Point(727, 340);
            this.rfPixelCtLbl.Name = "rfPixelCtLbl";
            this.rfPixelCtLbl.Size = new System.Drawing.Size(26, 17);
            this.rfPixelCtLbl.TabIndex = 7;
            this.rfPixelCtLbl.Text = "RF";
            this.rfPixelCtLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bonusFeaturesEnabledCBox
            // 
            this.bonusFeaturesEnabledCBox.AutoSize = true;
            this.bonusFeaturesEnabledCBox.Location = new System.Drawing.Point(149, 445);
            this.bonusFeaturesEnabledCBox.Name = "bonusFeaturesEnabledCBox";
            this.bonusFeaturesEnabledCBox.Size = new System.Drawing.Size(255, 21);
            this.bonusFeaturesEnabledCBox.TabIndex = 8;
            this.bonusFeaturesEnabledCBox.Text = "Enable Assignment Bonus Features";
            this.bonusFeaturesEnabledCBox.UseVisualStyleBackColor = true;
            this.bonusFeaturesEnabledCBox.CheckedChanged += new System.EventHandler(this.bonusFeaturesEnabledCBox_CheckedChanged);
            // 
            // nextInstructionLbl
            // 
            this.nextInstructionLbl.AutoSize = true;
            this.nextInstructionLbl.Location = new System.Drawing.Point(484, 445);
            this.nextInstructionLbl.Name = "nextInstructionLbl";
            this.nextInstructionLbl.Size = new System.Drawing.Size(46, 17);
            this.nextInstructionLbl.TabIndex = 9;
            this.nextInstructionLbl.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.nextInstructionLbl);
            this.Controls.Add(this.bonusFeaturesEnabledCBox);
            this.Controls.Add(this.rfPixelCtLbl);
            this.Controls.Add(this.rPixelCtLbl);
            this.Controls.Add(this.cPixelCtLbl);
            this.Controls.Add(this.lPixelCtLbl);
            this.Controls.Add(this.lfPixelCtLbl);
            this.Controls.Add(this.thresholdTrackBar);
            this.Controls.Add(this.binaryImagePictureBox);
            this.Controls.Add(this.origImagePictureBox);
            this.Name = "Form1";
            this.Text = "Sliced Pixel Counter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.origImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox origImagePictureBox;
        private System.Windows.Forms.PictureBox binaryImagePictureBox;
        private System.Windows.Forms.TrackBar thresholdTrackBar;
        private System.Windows.Forms.Label lfPixelCtLbl;
        private System.Windows.Forms.Label lPixelCtLbl;
        private System.Windows.Forms.Label cPixelCtLbl;
        private System.Windows.Forms.Label rPixelCtLbl;
        private System.Windows.Forms.Label rfPixelCtLbl;
        private System.Windows.Forms.CheckBox bonusFeaturesEnabledCBox;
        private System.Windows.Forms.Label nextInstructionLbl;
    }
}

